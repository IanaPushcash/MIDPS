//---------------------------------------------------------------------------

#include <vcl.h>
#pragma hdrstop

#include "Unit1.h"
//---------------------------------------------------------------------------
#pragma package(smart_init)
#pragma link "sButton"
#pragma link "sEdit"
#pragma link "sLabel"
#pragma resource "*.dfm"
#include <stdio.h>
#include <iostream>
#include <string.h>
using namespace std;
#include "dos.h"

TForm1 *Form1;
struct date d;
struct time t;
int i = 0;

//---------------------------------------------------------------------------
__fastcall TForm1::TForm1(TComponent* Owner)
        : TForm(Owner)
{
}
//---------------------------------------------------------------------------
void __fastcall TForm1::Timer1Timer(TObject *Sender)
{
char buf[20];
getdate(&d);
gettime(&t);
sprintf(buf,"%02d-%02d-%4d %02d:%02d:%02d",d.da_day,d.da_mon,d.da_year,
t.ti_hour,t.ti_min,t.ti_sec);
sEdit2->Text=(AnsiString)buf;

}
//---------------------------------------------------------------------------
void __fastcall TForm1::sButton1Click(TObject *Sender)
{
Timer2->Enabled = true;
sButton1->Enabled = false;
sButton2->Enabled = true;
sButton3->Enabled = false;
}
//---------------------------------------------------------------------------
void __fastcall TForm1::sButton2Click(TObject *Sender)
{
Timer2->Enabled = false;
sButton1->Enabled = false;
sButton2->Enabled = false;
sButton3->Enabled = true;
}
//---------------------------------------------------------------------------
void __fastcall TForm1::sButton3Click(TObject *Sender)
{
i = 0;
sEdit1->Text = "0 min 0 sec 0 zec";
sButton1->Enabled = true;
sButton2->Enabled = false;
sButton3->Enabled = false;
}
//---------------------------------------------------------------------------
void __fastcall TForm1::Timer2Timer(TObject *Sender)
{
i++;
AnsiString m=i/600;
AnsiString s=(i%600)/10;
AnsiString z=i%10;
sEdit1->Text = ""+m+" min "+s+" sec "+z+" zec";
}
//---------------------------------------------------------------------------
void __fastcall TForm1::sButton4Click(TObject *Sender)
{
Close();
}
//---------------------------------------------------------------------------

