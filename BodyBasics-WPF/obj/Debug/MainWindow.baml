   M S B A M L   `   `   `  ����  BodyBasics-WPF4    .Microsoft.Samples.Kinect.BodyBasics.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   -   5          � Title$  Body Analysis��5   	   $	��720��5   	   $
��1280��6    � 	Resources 5         MediumGreyBrush �� Color  KinectPurpleBrush  KinectBlueBrush��%�   &	        &	 #     &	 F     �� 5	   
   $ 	#ff6e6e6e��62   �� 5
   
   $ 	#ff52318f��64   �� 5   
   $ 	#ff00BCF2��62   5      .��5      � $��10,0,-581,-6q�6   $
��Left=�6!   $
��1263��6<    � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $��* �6   �� 5      $
��Auto �6    � ColumnDefinitions 5   
   �� 5      $��* �6   �� 5      $��* �6   .+�5   
   �� $��0��6   $��Images\Logo.png��6   $
��Left=�66   $
��Fill=�6Q   $��32��6`   $��81��6l   $��0 10 0 5q�6w   �� 5   
   $��0��6   $��0 0 -1 0q�6!   $��Right=�63   $��Bottom=�6O   #��[  6j   $��Segoe UI)�6�   $��18(�6�   Body Basics6�   �� 5   
   $��0��6   $��Images\Status.png��6   $
��None=�68   $��Center=�6G   $��0 0 0 5q�6d   (� 5   
   $��1��6   $��Center=�6   .��5      �� $��UniformToFill=�63   ��6   �� *ImageSource+63   5      �� 5!   
   -   5        $��	statusBar��5!   ?   $��2��6   $��Stretch=�6!   $��Bottom=�6P   
�������#��[  6~   .@�5"      �� ��6   �� *
StatusText+5#      �� 5%   
   -   5         ��Name$ navMainMenu��5%      $��Button��6&   $
��Left=�67   $��
451,16,0,0q�6R   $	��Top=�6f   $��75��6~   6�   �� 5&   
   -   5         ��Name$ textBox��5&      $
��Left=�6#   $��23��6>   $��
122,17,0,0q�6J    �� TextWrapping$
 Wrap=�6^   $��TextBox��6r   $	��Top=�6�   $	��120��6�   r� 5'   
   -   5         r�Name$ mediaElement��5'      $��Center=�6-   $	��820��6J   $��Center=�6X   $	��569��6s   $��1��6   $��2��6�   	 r� Source$	 C:\workout.mp4?�6�   $��2��6�   5(      5)      