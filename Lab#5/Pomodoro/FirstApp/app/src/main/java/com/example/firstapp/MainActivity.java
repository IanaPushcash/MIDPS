package com.example.firstapp;

import android.app.Activity;
import android.app.AlertDialog;
import android.content.Context;
import android.content.DialogInterface;
import android.content.Intent;
import android.media.AudioManager;
import android.media.SoundPool;
import android.os.CountDownTimer;
import android.os.Bundle;
import android.util.Log;
import android.view.View;
import android.widget.EditText;
import android.widget.TextView;

public class MainActivity extends Activity implements SoundPool.OnLoadCompleteListener {
    final int MAX_STREAMS = 5;
    public static SoundPool sp;
    public static int soundIdShot;

    static int workingTime;
    static int relaxTime;
    static int currentTime;
    static CountDownTimer timer;
    public static Context c;
    EditText textWork;
    EditText textRelax;
    static TextView time;
    static Boolean typeOftime = false;
    
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.main);

        textWork = (EditText) findViewById(R.id.TextWork);
        textRelax = (EditText) findViewById(R.id.TextRelax);
        time = (TextView) findViewById(R.id.time);

        sp = new SoundPool(MAX_STREAMS, AudioManager.STREAM_MUSIC, 0);
        sp.setOnLoadCompleteListener(this);

        soundIdShot = sp.load(this, R.raw.eralas, 1);
        workingTime = relaxTime = 0;
    }

    public void butStartOnClick(final View view) {
        try {
            stopService(new Intent(this, MyService.class));
        } catch (Exception e) {}
        try {
            workingTime = Integer.parseInt(textWork.getText().toString());
            relaxTime = Integer.parseInt(textRelax.getText().toString());
            currentTime = workingTime;
            typeOftime = false;
            c = view.getContext();
            startService(new Intent(c, MyService.class));
        } catch (Exception e) {
            workingTime = relaxTime = 0;
        }

    }

    static public void setTimer(final Context cont) {
        timer = new CountDownTimer(currentTime * 60 * 1000, 1000) {
            int i = 1;
            String str = "";

            public void onTick(long millisUntilFinished) {
                int cur = currentTime * 60 - i++;
                str = (cur / 60) + ":" + (cur % 60);
                time.setText(str);

            }

            public void onFinish() {
                sp.play(soundIdShot, 1, 1, 0, 0, 1);
                AlertDialog.Builder builder = new AlertDialog.Builder(cont);
                builder.setTitle("Важное сообщение!")
                        .setMessage((typeOftime ? "Для отдыха":"Рабочее") + " время истекло!")
                        .setCancelable(false)
                        .setNegativeButton("ОК",
                                new DialogInterface.OnClickListener() {
                                    public void onClick(DialogInterface dialog, int id) {
                                        if (currentTime == workingTime) {
                                            currentTime = relaxTime;
                                            typeOftime = true;
                                        }
                                        else {
                                            currentTime = workingTime;
                                            typeOftime = false;
                                        }
                                        setTimer(cont);
                                        dialog.cancel();
                                    }
                                });
                AlertDialog alert = builder.create();
                alert.show();


            }
        }.start();
    }


    public void butCancelOnClick(View view) {
        timer.cancel();
        stopService(new Intent(this, MyService.class));

    }

    @Override
    public void onLoadComplete(SoundPool soundPool, int sampleId, int status) {

    }
}
