object Form1: TForm1
  Left = 222
  Top = 174
  Width = 385
  Height = 344
  Caption = 'MIDPS 1- A'
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
    Left = 0
    Top = 36
    Width = 369
    Height = 21
    Alignment = taCenter
    AutoSize = False
    Caption = 'Incrementare decrementare contor.'
    ParentFont = False
    Font.Charset = DEFAULT_CHARSET
    Font.Color = clRed
    Font.Height = -16
    Font.Name = 'MS Sans Serif'
    Font.Style = []
  end
  object sLabel2: TsLabel
    Left = 0
    Top = 68
    Width = 369
    Height = 13
    Alignment = taCenter
    AutoSize = False
    Caption = 'i hasn'#39't changed'
  end
  object sButton1: TsButton
    Left = 48
    Top = 140
    Width = 75
    Height = 25
    Caption = 'UP'
    TabOrder = 0
    OnClick = sButton1Click
    SkinData.SkinSection = 'BUTTON'
  end
  object sButton2: TsButton
    Left = 48
    Top = 192
    Width = 75
    Height = 25
    Caption = 'DOWN'
    TabOrder = 1
    OnClick = sButton2Click
    SkinData.SkinSection = 'BUTTON'
  end
  object sButton3: TsButton
    Left = 228
    Top = 224
    Width = 75
    Height = 25
    Caption = 'EXIT'
    TabOrder = 2
    OnClick = sButton3Click
    SkinData.SkinSection = 'BUTTON'
  end
  object sEdit1: TsEdit
    Left = 148
    Top = 164
    Width = 121
    Height = 21
    TabOrder = 3
    Text = '0'
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
end
