   M S B A M L   `   `   `  ����@  <PLWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:PLWPFPLWPF  5   	        PLWPF.addHostingUnitWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   %localclr-namespace:PLWPF     5   	     � Title$  addHostingUnitWindow��5   	   $	��450��6&   $	��800��63   .��5	      �  � RowDefinitions 5
   
   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6    � ColumnDefinitions 5   
   �� 5      $��* �6   �� 5      $��* �6   .+�5    
   �� $
��Left=�6   $	��100��6+   $	��Top=�68   $	��100��6P   �� 5!   
   $��road-trip-compressor.png��6   $��0��62   $��15��6?   $��2��6Q    J� Opacity$	 0.5Q�6e   $
��Fill=�6s    J� RenderTransformOrigin$ 0.5,0.5&�6�   $��	-1,0,-3,0q�6�   z�5"      V� 5#      .~�5$      �� �� 5%       �� AngleX$
 0.13Q�6$   �� 5&      T� 5'       T� X$ -0.511Q�6)   5(      5*      �� 5,   
   $&�� הוספת יחידת אירוח��6   $��Right=�6,   $��Center=�6O   $	��Top=�6l   $��20(�6�   $��Lucida Calligraphy)�6�   $
��Bold"�6�   $��253,-5,292,0q�6�   $��2��6�   $	��247��6�   �� 5-   
   $��שם בעל יחידה��6   $��Right=�6(   $��1��6K   $��2��6[   $��Center=�6h   $��Center=�6�   $��15(�6�   $��Lucida Calligraphy)�6�   $
��Bold"�6�   $��108,0,152,0q�6�   $	��140��6�   �� 5.   
   $ ��שם יחידת אירוח��6   $��Right=�6+   $��1��6N   $��3��6^   $��Center=�6k   $��Center=�6�   $��15(�6�   $��Lucida Calligraphy)�6�   $
��Bold"�6�   $��126,0,152,0q�6�   $	��122��6�   �� 50   
   $��אזור הנופש��6   $��Right=�6&   $��1��6I   $��5��6Y   $��Center=�6f   $��Center=�6�   $��15(�6�   $��Lucida Calligraphy)�6�   $
��Bold"�6�   $��108,0,152,0q�6�   $	��140��6�   �� 51   
   $��תת איזור��6   $��Right=�6#   $��1��6F   $��6��6W   $��Center=�6d   $��Center=�6�   $��15(�6�   $��Lucida Calligraphy)�6�   $
��Bold"�6�   $��166,0,150,0q�6�   $��80��6�   �� 52   
   $��ברכה��6   $��Right=�6    $��1��6C   $��7��6S   $��Center=�6`   $��Center=�6}   $��15(�6�   $��Lucida Calligraphy)�6�   $
��Bold"�6�   $��150,0q�6�   $��96��6�   �� 53   
   $��מספר אנשים��6   $��Right=�6%   $��1��6H   $��8��6Y   $��Center=�6f   $��Center=�6�   $��15(�6�   $��Lucida Calligraphy)�6�   $
��Bold"�6�   $��126,0,152,0q�6�   $	��122��6�   �� 54   
   $��מספר ילדים��6   $��Right=�6&   $��1��6I   $��9��6Y   $��Center=�6f   $��Center=�6�   $��15(�6�   $��Lucida Calligraphy)�6�   $
��Bold"�6�   $��
56,0,150,0q�6�   $	��190��6�   $ 0.243,0.482&�6�   �� 55   
   $��
גקוזי��6   $��Right=�6    $��1��6C   $��10��6T   $��Center=�6b   $��Center=�6   $��15(�6�   $��Lucida Calligraphy)�6�   $
��Bold"�6�   $��
86,0,150,0q�6�   $	��160��6�   �� 56   
   $��גינה��6   $��Right=�6    $��1��6C   $��11��6S   $��Center=�6a   $��Center=�6~   $��15(�6�   $��Lucida Calligraphy)�6�   $
��Bold"�6�   $��162,0,150,0q�6�   $��84��6�   �� 57   
   $��משחקי ילדים��6   $��Right=�6&   $��1��6I   $��12��6Z   $��Center=�6h   $��Center=�6�   $��15(�6�   $��Lucida Calligraphy)�6�   $
��Bold"�6�   $��124,0,150,0q�6�   $	��122��6�   �� 58   
   $��כוכבים��6   $��Right=�6!   $��1��6D   $��13��6U   $��Center=�6c   $��Center=�6�   $��15(�6�   $��Lucida Calligraphy)�6�   $
��Bold"�6�   $��124,0,150,0q�6�   $	��122��6�   �� 5;   
   -   5         ��Name$ Owner��5;      $��2��6!   $��0��6/   $��23��6?    �� TextWrapping$
 Wrap=�6K   $	��120��6v   $	 0.6Q�6�   ��6_   �� *Owner+6�   �� 5<   
   -   5        $ HostingUnitName��5<      $��3��6+   $��0��69   $��23��6I   $
 Wrap=�6U   $	��120��6�   $	 0.6Q�6�   ��6i   �� *HostingUnitName+6�   �� 5>   
   -   5        	 ��Name$
	 Area��5>      $��5��6W   $��0��6d   $	��120��6t   $��Center=�6�   $��138,4q�6�   $	 0.6Q�6�   ��6!   �� 
 �� SelectedItem
 69   �� *area+6�   �� 5?   
   -   5        $ subArea��5?      $��6��6#   $��0��60   $	��120��6@   $��Center=�6e   $��138,4q�6�   $	 0.6Q�6�   ��6L   �� *	subArea+6�   �� 5A   
   -   5        $ adults��5A      $��8��6"   $��0��60   $��23��6@   $
 Wrap=�6L   $	��120��6x   $	 0.6Q�6�   ��6`   �� *adults+6�   �� 5B   
   -   5        $
 kids��5B      $��9��6    $��0��6.   $��23��6>   $
 Wrap=�6J   $	��120��6t   $	 0.6Q�6�   ��6^   �� *kids+6�   �� 5C   
   -   5        $��radioJaccuzi��5C      $��10��6'   .��5D      �� $��289,-3,-289,-7q�6   .+�5E      	� -   5        $��jacuzziOption1��5E       	� 	GroupName$ radioJaccuzi��64   $��בלי��6M   $��0,0,0,0q�6[   	� 5F      -	   5        $��jacuzziOption2��5F      $ radioJaccuzi��64   $
��עם��6M   $��	0,0,346,0q�6Z   5G      5H      �� 5I   
   -
   5        $��radioGarden��5I      $��11��6&   .��5J      �� $��289,-3,-289,-7q�6   .+�5K      	� -   5        $��gardenOption1��5K      $ radioGarden��63   $��בלי��6K   $��0,0,0,0q�6Y   	� 5L      -   5        $��gardenOption2��5L      $ radioGarden��63   $
��עם��6K   $��0,0,0,0q�6X   5M      5N      �� 5O   
   -   5        $��radioAttraction��5O      $��12��6*   .��5P      �� $��289,-3,-289,-7q�6   .+�5Q      	� -   5        $��attractionOption1��5Q      $ radioAttraction��67   $��בלי��6S   $��0,0,0,0q�6a   	� 5R      -   5        $��attractionOption2��5R      $ radioAttraction��67   $
��עם��6S   $��0,0,0,0q�6`   5S      5T      �� 5U   
   -   5        $��	radioPool��5U      $��7��6$   .��5V      �� $��289,-3,-289,-7q�6   .+�5W      	� -   5        $��poolOption1��5W      $ 	radioPool��61   $��בלי��6G   $��0,0,0,0q�6U   	� 5X      -   5        $��poolOption2��5X      $ 	radioPool��61   $
��עם��6G   $��0,0,0,0q�6T   5Y      5Z      �� 5[   
   -   5        $��
הוספה��5[      $��Center=�6"   $��13��6?   $��Center=�6N   $	��144��6i   $��2��6u   $��30��6�   $
��Bold"�6�   $��20(�6�   $��325,21,323,5q�6�   $��2��6�   �� 5\   
   $
��Left=�6   $
��Wrap=�6/   $�� ��6C   $	��Top=�6K   $ 2.138,8.793&�6c   $��12��6�   ���	#FFE69F7F$��	788,0,0,0q�6�   $	��450��6�   �� 5_   
   -   5        $ stars��5_      $
��Left=�6!   $��23��6<   $
 Wrap=�6H   $��Bottom=�6s   $��55��6�   $��	240,0,0,4q�6�   $��13��6�   ��6\   �� *stars+6�   5a      5i      