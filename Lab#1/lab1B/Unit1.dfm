object Form1: TForm1
  Left = 192
  Top = 152
  Width = 544
  Height = 380
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
  object sLabel1: TsLabel
    Left = 224
    Top = 156
    Width = 171
    Height = 24
    Caption = 'C++ Builder Timer'
    ParentFont = False
    Font.Charset = DEFAULT_CHARSET
    Font.Color = clRed
    Font.Height = -19
    Font.Name = 'MS Sans Serif'
    Font.Style = [fsBold]
  end
  object sLabel2: TsLabel
    Left = 284
    Top = 32
    Width = 125
    Height = 20
    Caption = #1057'++ Builder Timer'
    ParentFont = False
    Font.Charset = DEFAULT_CHARSET
    Font.Color = clRed
    Font.Height = -16
    Font.Name = 'MS Sans Serif'
    Font.Style = []
  end
  object sButton1: TsButton
    Left = 72
    Top = 168
    Width = 75
    Height = 25
    Caption = 'START'
    TabOrder = 0
    OnClick = sButton1Click
    SkinData.SkinSection = 'BUTTON'
  end
  object sButton2: TsButton
    Left = 72
    Top = 208
    Width = 75
    Height = 25
    Caption = 'STOP'
    Enabled = False
    TabOrder = 1
    OnClick = sButton2Click
    SkinData.SkinSection = 'BUTTON'
  end
  object sButton3: TsButton
    Left = 72
    Top = 248
    Width = 75
    Height = 25
    Caption = 'ZERO'
    Enabled = False
    TabOrder = 2
    OnClick = sButton3Click
    SkinData.SkinSection = 'BUTTON'
  end
  object sButton4: TsButton
    Left = 380
    Top = 288
    Width = 75
    Height = 25
    Caption = 'EXIT'
    TabOrder = 3
    OnClick = sButton4Click
    SkinData.SkinSection = 'BUTTON'
  end
  object sEdit1: TsEdit
    Left = 216
    Top = 204
    Width = 273
    Height = 37
    Font.Charset = DEFAULT_CHARSET
    Font.Color = clWindowText
    Font.Height = -24
    Font.Name = 'MS Sans Serif'
    Font.Style = []
    ParentFont = False
    TabOrder = 4
    Text = '0 min 0 sec 0 zec'
    SkinData.SkinSection = 'EDIT'
    BoundLabel.Indent = 0
    BoundLabel.Font.Charset = DEFAULT_CHARSET
    BoundLabel.Font.Color = clWindowText
    BoundLabel.Font.Height = -11
    BoundLabel.Font.Name = 'MS Sans Serif'
    BoundLabel.Font.Style = []
    BoundLabel.Layout = sclLeft
    BoundLabel.MaxWidth = 0
    BoundLabel.UseSkinColor = True
  end
  object sEdit2: TsEdit
    Left = 264
    Top = 104
    Width = 221
    Height = 21
    TabOrder = 5
    SkinData.SkinSection = 'EDIT'
    BoundLabel.Indent = 0
    BoundLabel.Font.Charset = DEFAULT_CHARSET
    BoundLabel.Font.Color = clWindowText
    BoundLabel.Font.Height = -11
    BoundLabel.Font.Name = 'MS Sans Serif'
    BoundLabel.Font.Style = []
    BoundLabel.Layout = sclLeft
    BoundLabel.MaxWidth = 0
    BoundLabel.UseSkinColor = True
  end
  object Timer1: TTimer
    OnTimer = Timer1Timer
    Left = 36
    Top = 48
  end
  object Timer2: TTimer
    Enabled = False
    Interval = 100
    OnTimer = Timer2Timer
    Left = 36
    Top = 92
  end
end
