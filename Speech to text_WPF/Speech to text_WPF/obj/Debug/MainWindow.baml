   M S B A M L   `   `   `  ����M  ISpeech to text_WPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:Speech_to_text_WPFSpeech_to_text_WPF  5   	   #    Speech_to_text_WPF.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   2local clr-namespace:Speech_to_text_WPF     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)   .��5	      �  � ColumnDefinitions 5
   
   �� 5      6!   �� 5      $
��auto �6   6.   .+�5   
   �� $��Visible=�6   .��5      �� -   5         ��Name$ txtText��5       �� AcceptsReturn .  �� TextWrapping$
 Wrap=�6<   6R   5      � 5   
   $��1��6    � RowDefinitions 5      �� 5      $
��auto �6    60   �� 5      $
��auto �6    60   .+�5      �� -   5         ��Name$ btnStart��5   <   $��Start��6   6P   �� 5      -   5        $ btnStop��5   G   $��1��6   $
��Stop��68   6Z   5      5      5      