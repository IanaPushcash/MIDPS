package com.example.firstapp;

import android.annotation.TargetApi;
import android.app.AlertDialog;
import android.app.Application;
import android.app.NotificationManager;
import android.app.PendingIntent;
import android.content.Context;
import android.content.DialogInterface;
import android.content.Intent;
import android.content.res.Resources;
import android.os.Build;
import android.os.CountDownTimer;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.EditText;
import android.app.Notification;
import android.widget.TextView;

import java.util.Timer;

public class MainActivity extends AppCompatActivity {

    static int tW;
    static int tR;
    static int currentTime;
    static CountDownTimer tim1;
    public static Context c;
    EditText textWork;
    EditText textRelax;
    private static final int NOTIFY_ID = 101;
    static TextView time;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.main);

        textWork = (EditText) findViewById(R.id.TextWork);
        textRelax = (EditText) findViewById(R.id.TextRelax);
        time = (TextView) findViewById(R.id.time);

    }

    public void butStartOnClick(final View view){
        tW = Integer.parseInt(textWork.getText().toString());
        tR = Integer.parseInt(textRelax.getText().toString());
        currentTime = tW;
        c = view.getContext();
        startService(new Intent(c, MyService.class));
        //setTimer(view);
    }

    static public void setTimer(final Context cont){
        tim1 = new CountDownTimer(currentTime*60*1000, 1000) {
            int i = 1;
            String str = "";
            public void onTick(long millisUntilFinished) {
                int cur = currentTime*60 - i++;
                str = (cur/60) + ":" + (cur%60);
                time.setText(str);

            }

            public void onFinish() {
                AlertDialog.Builder builder = new AlertDialog.Builder(cont);
                builder.setTitle("Важное сообщение!")
                        .setMessage("Время истекло!")
                        .setCancelable(false)
                        .setNegativeButton("ОК",
                                new DialogInterface.OnClickListener() {
                                    public void onClick(DialogInterface dialog, int id) {
                                        dialog.cancel();
                                    }
                                });
                AlertDialog alert = builder.create();
                alert.show();
                if (currentTime == tW) currentTime = tR;
                else currentTime = tW;
                setTimer(cont);
            }
        }.start();
    }



    public void butCancelOnClick(View view){
        tim1.cancel();
        stopService(new Intent(this, MyService.class));

    }
}
