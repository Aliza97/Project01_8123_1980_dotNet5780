   M S B A M L   `   `   `  ���� @  <PLWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:PLWPFPLWPF       PLWPF.addHostingUnitWindow   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     %localclr-namespace:PLWPF       � Title$  addHostingUnitWindow��$	��450��$	��800��.���  � RowDefinitions �� $��* ��� $��* ��� $��* ��� $��* ��� $��* ��� $��* ��� $��* ��� $��* ��� $��* ��� $��* ��� $��* ��� $��* ��� $��* ��� $��* ��� $��* � � ColumnDefinitions �� $��* ��� $��* �.+��� $
��Left=�$	��100��$	��Top=�$	��100���� $��road-trip-compressor.png��$��0��$��15��$��2�� J� Opacity$	 0.5Q�$
��Fill=� J� RenderTransformOrigin$ 0.5,0.5&�$��	-1,0,-3,0q�z�V� .~��� ��  �� AngleX$
 0.13Q��� T�  T� X$ -0.511Q��� $&�� הוספת יחידת אירוח��$��Right=�$��Center=�$	��Top=�$��20(�$��Lucida Calligraphy)�$
��Bold"�$��253,-5,292,0q�$��2��$	��247���� $��שם בעל יחידה��$��Right=�$��1��$��2��$��Center=�$��Center=�$��15(�$��Lucida Calligraphy)�$
��Bold"�$��108,0,152,0q�$	��140���� $ ��שם יחידת אירוח��$��Right=�$��1��$��3��$��Center=�$��Center=�$��15(�$��Lucida Calligraphy)�$
��Bold"�$��126,0,152,0q�$	��122���� $��אזור הנופש��$��Right=�$��1��$��5��$��Center=�$��Center=�$��15(�$��Lucida Calligraphy)�$
��Bold"�$��108,0,152,0q�$	��140���� $��תת איזור��$��Right=�$��1��$��6��$��Center=�$��Center=�$��15(�$��Lucida Calligraphy)�$
��Bold"�$��166,0,150,0q�$��80���� $��ברכה��$��Right=�$��1��$��7��$��Center=�$��Center=�$��15(�$��Lucida Calligraphy)�$
��Bold"�$��150,0q�$��96���� $��מספר אנשים��$��Right=�$��1��$��8��$��Center=�$��Center=�$��15(�$��Lucida Calligraphy)�$
��Bold"�$��126,0,152,0q�$	��122���� $��מספר ילדים��$��Right=�$��1��$��9��$��Center=�$��Center=�$��15(�$��Lucida Calligraphy)�$
��Bold"�$��
56,0,150,0q�$	��190��$ 0.243,0.482&��� $��
גקוזי��$��Right=�$��1��$��10��$��Center=�$��Center=�$��15(�$��Lucida Calligraphy)�$
��Bold"�$��
86,0,150,0q�$	��160���� $��גינה��$��Right=�$��1��$��11��$��Center=�$��Center=�$��15(�$��Lucida Calligraphy)�$
��Bold"�$��162,0,150,0q�$��84���� $��משחקי ילדים��$��Right=�$��1��$��12��$��Center=�$��Center=�$��15(�$��Lucida Calligraphy)�$
��Bold"�$��124,0,150,0q�$	��122���� $��כוכבים��$��Right=�$��1��$��13��$��Center=�$��Center=�$��15(�$��Lucida Calligraphy)�$
��Bold"�$��124,0,150,0q�$	��122���� -    ��Name$ Owner��$��2��$��0��$��23�� �� TextWrapping$
 Wrap=�$	��120��$	 0.6Q����� *Owner+�� -   $ HostingUnitName��$��3��$��0��$��23��$
 Wrap=�$	��120��$	 0.6Q����� *HostingUnitName+�� -   	 ��Name$
	 Area��$��5��$��0��$	��120��$��Center=�$��138,4q�$	 0.6Q����� 
 �� SelectedItem
 �� *area+�� -   $ subArea��$��6��$��0��$	��120��$��Center=�$��138,4q�$	 0.6Q����� *	subArea+�� -   $ adults��$��8��$��0��$��23��$
 Wrap=�$	��120��$	 0.6Q����� *adults+�� -   $
 kids��$��9��$��0��$��23��$
 Wrap=�$	��120��$	 0.6Q����� *kids+�� -   $��radioJaccuzi��$��10��.���� $��289,-3,-289,-7q�.+�	� -   $��jacuzziOption1�� 	� 	GroupName$ radioJaccuzi��$��בלי��$��0,0,0,0q�	� -	   $��jacuzziOption2��$ radioJaccuzi��$
��עם��$��	0,0,346,0q��� -
   $��radioGarden��$��11��.���� $��289,-3,-289,-7q�.+�	� -   $��gardenOption1��$ radioGarden��$��בלי��$��0,0,0,0q�	� -   $��gardenOption2��$ radioGarden��$
��עם��$��0,0,0,0q��� -   $��radioAttraction��$��12��.���� $��289,-3,-289,-7q�.+�	� -   $��attractionOption1��$ radioAttraction��$��בלי��$��0,0,0,0q�	� -   $��attractionOption2��$ radioAttraction��$
��עם��$��0,0,0,0q��� -   $��	radioPool��$��7��.���� $��289,-3,-289,-7q�.+�	� -   $��poolOption1��$ 	radioPool��$��בלי��$��0,0,0,0q�	� -   $��poolOption2��$ 	radioPool��$
��עם��$��0,0,0,0q��� -   $��
הוספה��$��Center=�$��13��$��Center=�$	��144��$��2��$��30��$
��Bold"�$��20(�$��325,21,323,5q�$��2���� $
��Left=�$
��Wrap=�$�� ��$	��Top=�$ 2.138,8.793&�$��12�����	#FFE69F7F$��	788,0,0,0q�$	��450���� -   $ stars��$
��Left=�$��23��$
 Wrap=�$��Bottom=�$��55��$��	240,0,0,4q�$��13������ *stars+