   M S B A M L   `   `   `  ����  
verbs2mvvm    verbs2mvvm.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	     � Title$  
MainWindow��5   	   $	��350��6   $	��525��6)    � 	Resources 5       �� 
TargetType �� Property �� Value��%  '��       '�� H     '�� �     �� 5      " ��6   .�5      ��  � ��$ 14(�6-   5      �� 5	      " ��6   .�5
      ��  � ��$ 14(�6-   5      �� 5      " ��6   .�5      ��  � ��$ 40��6*   �� 5       � ��$ 5q�6+   5      5      .��5      �  � ColumnDefinitions 5   
   �� 5      $��* �6   �� 5      $
��0.8* �6    � RowDefinitions 5   
   �� 5      $��* �6   �� 5      $
��0.2* �6   .+�5   
   �� $��0��6   ��6"   �� *Verbs+ �� SelectedItem 5      �� *SelectedVerb+��5      �� 5      .R�5      �� $��5q�6!   .+�5       �� ��6$   ��  �� Path$ Verb1��� 5!      ��6$   �� $ Verb2��� 5"      ��6$   �� $ Verb3�5#      5$      5&      �� 5(   
   $��1��6   	 �� Orientation$	 
Horizontal=�6"   .+�5)      �� ��6   �� *
AddCommand+.��64   +67   5*      �� 5,   
   $��1��6   
 � DataContext
 6%   �� *SelectedVerb+.+�5-      �� $'��!Выбранный элемент��6   �� 5.      $��Глагол №1��6   �� 5/      ��6   �� *Verb1+ �� UpdateSourceTrigger$ PropertyChanged=��� 50      $��Глагол №2��6   �� 51      ��6   �� *Verb2+$ PropertyChanged=��� 52      $��Глагол №3��6   �� 53      ��6   �� *Verb3+$ PropertyChanged=�54      55   
   56      