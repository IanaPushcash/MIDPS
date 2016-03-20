//---------------------------------------------------------------------------

#include <vcl.h>
#pragma hdrstop
#include <stdio.h>

#include "Unit1.h"
#include "Dos.h"

//---------------------------------------------------------------------------
#pragma package(smart_init)
#pragma resource "*.dfm"
struct time t;
struct date d;
int width;
int height;
int x;
int y;

TForm1 *Form1;
//---------------------------------------------------------------------------
__fastcall TForm1::TForm1(TComponent* Owner)
        : TForm(Owner)
{
Button2->Enabled = false;
srand(time(NULL));

}
//---------------------------------------------------------------------------

void __fastcall TForm1::PaintBox1Paint(TObject *Sender)
{
PaintBox1->Canvas->Pen->Color = clBlack;
PaintBox1->Canvas->Brush->Color = clBlack;
PaintBox1->Canvas->Brush->Style = bsCross;
PaintBox1->Canvas->Rectangle(0, 0, PaintBox1->Width, PaintBox1->Height);

}
//---------------------------------------------------------------------------




void __fastcall TForm1::Button3Click(TObject *Sender)
{
Close();
}
//---------------------------------------------------------------------------

void __fastcall TForm1::Timer1Timer(TObject *Sender)
{
char buf[20];
getdate(&d);
gettime(&t);
sprintf(buf,"%02d-%02d-%4d %02d:%02d:%02d",d.da_day,d.da_mon,d.da_year,t.ti_hour,t.ti_min,t.ti_sec);
Edit1->Text=(AnsiString)buf;
}
//---------------------------------------------------------------------------
void DrawLine()
{
y = (height / 2.0) + (rand() % Form1->PaintBox1->Height/4 - Form1->PaintBox1->Height/8);
Form1->PaintBox1->Canvas->LineTo(++x, y);
Form1->Panel1->Height = y;
}


void __fastcall TForm1::Button1Click(TObject *Sender)
{
PaintBox1->Repaint();
PaintBox1->Canvas->Pen->Color = clRed;
width = Form1->PaintBox1->Width;
height = Form1->PaintBox1->Height;
x = 0;
PaintBox1->Canvas->MoveTo(0, height / 2.0);
Button2->Enabled = true;
Button1->Enabled = false;
Timer2->Enabled = true;

}
//---------------------------------------------------------------------------


void __fastcall TForm1::Button2Click(TObject *Sender)
{
Timer2->Enabled = false;
Button1->Enabled = true;
Button2->Enabled = false;

}
//---------------------------------------------------------------------------

void __fastcall TForm1::Timer2Timer(TObject *Sender)
{
if(x == width)
        Button2Click(Sender);
else DrawLine();

}
//---------------------------------------------------------------------------

