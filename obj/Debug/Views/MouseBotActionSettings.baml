   M S B A M L   `   `   `  ����B  >EasyBot, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:EasyBot.ViewsEasyBot.Views  5   	   *    $EasyBot.Views.MouseBotActionSettings   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -localclr-namespace:EasyBot.Views     5   	   -   5          � Title$  Change Mouseaction��5   	    � Icon$/ )/EasyBot;component/Images/EasyBotLogo.png��6$   $	��450��6U   $	��800��6b   ���#151515 � WindowStartupLocation$ CenterScreen=�6�    � WindowStyle$
 None=�6�    � AllowsTransparency . '  !System.Windows.Shell.WindowChrome   WindowChrome 5        5   
      CaptionHeight$ 40Q�6   .��5      �  � RowDefinitions 5   
   �� 5      $��40 �6   �� 5      �� 5      �� 5      �� 5      $��80 �6   .+�5   
   � $	��Top=�6   ���#2f3542$��40��6<   .+�5      �� $��EasyBot��6   $��Center=�6&   $��Center=�6A      	DarkLabel#��[  6^   �� 5      -   5        $��WindowControls��5   �      IsHitTestVisibleInChrome . $��Center=�6F   $��Right=�6a   	 �� Orientation$	 
Horizontal=�6}   .+�5      �� -   5        $��Button_Minimize��5   H   $��40��6   $��40��6%   $��-��60   $��0q�6<     
DarkButton#��[ 6_   
������ 6�   �� 5       -   5        $��Button_Close��5    H   $��40��6   $��40��6%   $��x��60   $��0q�6<   #��[ 6\   
������ 6�   5"      5#      �� 5%   
   $��1��6   $��Center=�6"   $��Center=�6?   .+�5&      �� $	 
Horizontal=�6   .+�5'      �� $	��X: ��6   #��[  6&   �� 5(      -   5        $��Label_X_Value��5(   #   $�� ��6   #��[  68   �� 5)      $	��Y: ��6   #��[  6&   �� 5*      -   5        $��Label_Y_Value��5*   #   $�� ��6   #��[  68   �� 5,      -   5        $��Button_SetLocation��5,   i   $��Set location��6   #��[ 60   ���#00b894$��10,0,0,0q�6�   6�   �� 5-      -   5        $��Button_TestLocation��5-   |   $��Test location��6   #��[ 61   ���#f0932b$��20,0,0,0q�6j   6�   5.      �� 50      -	   5        
 ��Name$
 Label_SetLocationInfo��50   �   $��Press F8 to set location��6   #��[  67   $��Center=�6Z   $��15(�6w   $y�	Collapsed=�6�   6�   51      �� 53   
   $	 
Horizontal=�6   $��Center=�6.   $��Center=�6K   $��2��6f   .+�54      	� -
   5        $��RadioButton_Leftclick��54   X   $��
Left click��6     DarkRadioButton#��[ 6/   $��0,0,10,0q�6u    d� 	IsChecked$
 TrueY�6�   	� 55      -   5        $��RadioButton_Rightclick��55   Y   $��Right click��6   #��[ 60   $��	10,0,10,0q�6w   56      �� 58   
   $	 Vertical=�6   $��Center=�6,   $��Center=�6I   $��3��6d   .+�59      �� -   5        $��TextBox_Delay��59   ;     DarkTextBox#��[ 6   $��0��6P   $
��Bold"�6Y   6k   �� 5:      $��Delay (in milliseconds)��6   #��[  66   5;      � 5>   
   $��4��6    � ColumnDefinitions 5@      �� 5B      �� 5C      .+�5G      �� -   5        $��Button_Save��5G   m   $��0��6   #��[ 6%   $
��Save��6I   ���#2ecc716�   �� 5I      -   5        $��Button_Delete��5I   o   $��1��6   #��[ 6%   $��Delete��6I   ���#ff76756�   5K      5O      5P      