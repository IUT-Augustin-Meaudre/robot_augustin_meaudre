   M S B A M L   `   `   `  ����I  ERobotInterface, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:RobotInterfaceRobotInterface  5   	       RobotInterface.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .localclr-namespace:RobotInterface     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)   .��5	      � -   5         � ColumnDefinitions 5
   
   �� 5      $��1* �6   �� 5      $	��30* �6   �� 5      $��1* �6   �� 5      $	��30* �6   �� 5      $��1* �6    � RowDefinitions 5   
   �� 5      $��10 �6   �� 5      $	��10* �6   �� 5      $��1* �6   �� 5      $��1* �6   �� 5      $��10 �6   .+�5   
   �� -   5         ��Name$ Emission��5      $��1��6%   $��1��65   $��Emission��6B   ���	#FFDDDDDD
���   �$��0,0,0,0q�6   .��5      �� -   5         ��Name$ textBoxEmission��5      $��Stretch=�6/   $
��Auto��6M   $��0,0,0,0q�6[    �� TextWrapping$
 Wrap=�6l   $��Stretch=�6�   $
��Auto��6�    �� AcceptsReturn . 6�   5      �� 5   
   -   5        $ 	Reception��5      $��3��6&   $��1��66   $��	Reception��6C   ���	#FFDDDDDD
���   �$��0,0,0,0q�6�   .��5      �� -   5        $ textBoxReception��5      $��Stretch=�60   $
��Auto��6N   $��0,0,0,0q�6\   $
 Wrap=�6m   $��Stretch=�6�   $
��Auto��6�    �� 
IsReadOnly . 6�   5       �� 5!   
   -   5         ��Name$ ButtonEnvoyer��5!      $��Envoyer��6(   $��1��6:   $��Stretch=�6J   $
��Auto��6h   $��0,0,0,0q�6v   $��3��6�   $��Stretch=�6�   $	��100��6�   $��12(�6�   6�   �� 5"   
   -   5        $ ButtonClear��5"      $��Clear��6&   $��3��66   $��Stretch=�6F   $
��Auto��6d   $��0,0,0,0q�6r   $��3��6�   $��Stretch=�6�   $	��100��6�   $��12(�6�   6�   �� 5#   
   -   5        $ 
ButtonTest��5#      $
��Test��6%   $��1��64   $��Stretch=�6D   $
��Auto��6b   $��0,0,0,0q�6p   $��2��6�   $��Stretch=�6�   $	��100��6�   $��12(�6�   6�   �� 5$   
   -	   5        $ ButtonHello��5$      $��Hello��6&   $��3��66   $��Stretch=�6F   $
��Auto��6d   $��0,0,0,0q�6r   $��2��6�   $��Stretch=�6�   $	��100��6�   $��12(�6�   6�   5'      5(      