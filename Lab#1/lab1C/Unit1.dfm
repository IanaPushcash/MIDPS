object Form1: TForm1
  Left = 182
  Top = 151
  Width = 590
  Height = 465
  Hint = 'Start'
  Caption = 'MIDPS'
  Color = clBtnFace
  Font.Charset = DEFAULT_CHARSET
  Font.Color = clWindowText
  Font.Height = -11
  Font.Name = 'MS Sans Serif'
  Font.Style = []
  OldCreateOrder = False
  PixelsPerInch = 96
  TextHeight = 13
  object PaintBox1: TPaintBox
    Left = 224
    Top = 176
    Width = 305
    Height = 213
    OnPaint = PaintBox1Paint
  end
  object Label1: TLabel
    Left = 320
    Top = 44
    Width = 209
    Height = 17
    Alignment = taRightJustify
    AutoSize = False
    Caption = 'Current date and time'
    Font.Charset = DEFAULT_CHARSET
    Font.Color = clWindowText
    Font.Height = -16
    Font.Name = 'MS Sans Serif'
    Font.Style = [fsBold]
    ParentFont = False
  end
  object Label2: TLabel
    Left = 267
    Top = 108
    Width = 262
    Height = 20
    Alignment = taRightJustify
    Caption = 'C++ Builder Graphics Resources'
    Font.Charset = DEFAULT_CHARSET
    Font.Color = clWindowText
    Font.Height = -16
    Font.Name = 'MS Sans Serif'
    Font.Style = [fsBold]
    ParentFont = False
  end
  object Button1: TButton
    Left = 24
    Top = 212
    Width = 75
    Height = 25
    Caption = 'START'
    ParentShowHint = False
    ShowHint = True
    TabOrder = 2
    OnClick = Button1Click
  end
  object Button2: TButton
    Left = 24
    Top = 264
    Width = 75
    Height = 25
    Hint = 'Stop'
    Caption = 'STOP'
    ParentShowHint = False
    ShowHint = True
    TabOrder = 3
    OnClick = Button2Click
  end
  object Button3: TButton
    Left = 24
    Top = 312
    Width = 75
    Height = 25
    Hint = 'Exit'
    Caption = 'EXIT'
    ParentShowHint = False
    ShowHint = True
    TabOrder = 4
    OnClick = Button3Click
  end
  object Panel2: TPanel
    Left = 144
    Top = 176
    Width = 49
    Height = 213
    Color = clBtnShadow
    TabOrder = 1
  end
  object Edit1: TEdit
    Left = 412
    Top = 68
    Width = 117
    Height = 21
    TabOrder = 5
  end
  object Panel1: TPanel
    Left = 144
    Top = 176
    Width = 49
    Height = 106
    Color = clBlack
    TabOrder = 0
  end
  object Timer1: TTimer
    OnTimer = Timer1Timer
    Left = 28
    Top = 36
  end
  object Timer2: TTimer
    Interval = 100
    OnTimer = Timer2Timer
    Left = 28
    Top = 80
  end
end
