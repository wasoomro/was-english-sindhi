   M S B A M L   `   `   `  ����M  IWAS-English-Sindhi, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:WAS_English_SindhiWAS_English_Sindhi  5   	   #    WAS_English_Sindhi.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   2local clr-namespace:WAS_English_Sindhi     5   	   -   5          � Title$&   WAS English To Sindhi Dictionary��5   	   $	��480��62   $	��640��6?   .��5      � $��5q�6   
������� � ColumnDefinitions 5   
   �� 5      $��1* �6   �� 5      $��5 �6   �� 5      $��2* �6    � RowDefinitions 5   
   �� 5      $��40 �6   �� 5      $��43 �6   �� 5      $��20 �6   �� 5      $��* �6   .+�5    
   �� -   5         ��Name$ searchLabel��5    �   $��Center=�6   $��center=�62   ���	#FF008BFF
�������$��0��6�   $��0��6�   $��Search And Index��6�   $��14(�6�   $��Medium"�6�   � 5$   
   $��0��6   $��1��6   $��5,10,5,0q�6,    5%      �� 5&      $��* �6#   �� 5'      $��43 �6#   .+�5*      �� -   5         ��Name$ 	searchBox��5*   e   $��Center=�63   $��0��6U   6e   �� 5+      -   5         ��Name$ searchButton��5+   0   $��GO��6F   $��1��6S   $��43��6d   $��Right=�6o   5-      �� 5.   
   -   5         ��Name$ indexBox��5.   @   $��2��6S   $��0��6d   $��5,10,5,2q�6t   $��2��6�   �� 53   
   $��1��6   $��0��6(   $��4��65   $��Stretch=�6F   �� 56   
   $��0,0,0,2q�6   
���   � J� RenderTransformOrigin$ 0.5,0.5&�6?   $��2��6_   $��0��6o   ._�57      ��  �� Orientation$ 
Horizontal=�6   .+�58      �� -   5        $ wordText��58   Q   $��5,0,0,0q�6   $��0,-2,8,0q�6+   
���   �$��Search And Index��6c   $��32(�6~   $
��Bold"�6�   �� 5:      -   5        	 ��Name$	 	soundIcon��5:   o   $��	sound.png��6   $��32��6G   $��32��6R   $��0,5,0,0q�6^   6o   5<      5=      �� 5?   
   -   5        
 ��Name$
 dicTab��5?   '   $��0,10,0,2q�6   $��2��67   $��1��6G   $��3��6T   .@�5@      �� -	   5         ��Name$ 
en_sin_tab��5@   '   $��General��6   .��5A      � .+�5B      �� -
   5         ��Name$ en_sin_list��5B      $��RightToLeft=�64   $��16(�6P   $
��Bold"�6^   $��5q�6p   5C      5D      �� 5E      -   5        $ 	cbank_tab��5E   0   $��Commerce Banking��6   .��5F      � .+�5G      �� -   5        $ 
cbank_list��5G      $��RightToLeft=�63   $��16(�6O   $
��Bold"�6]   $��5q�6o   5H      5I      �� 5J      -   5        $ geog_sin_tab��5J   )   $��	Geography��6   .��5K      � .+�5L      �� -   5        $ geog_sin_list��5L      $��RightToLeft=�66   $��16(�6R   $
��Bold"�6`   $��5q�6r   5M      5N      �� 5O      -   5        $ off_term_tab��5O   .   $��Official Terms��6   .��5P      � .+�5Q      �� -   5        $ off_term_list��5Q      $��RightToLeft=�66   $��16(�6R   $
��Bold"�6`   $��5q�6r   5R      5S      5T      5W      5X      