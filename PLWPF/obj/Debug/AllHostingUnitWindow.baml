   M S B A M L   `   `   `  ����@  <PLWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:PLWPFPLWPF  5   	   = 9BE, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:BE;assembly=BEBE 5   	        PLWPF.AllHostingUnitWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   %localclr-namespace:PLWPF     5   	   +BEclr-namespace:BE;assembly=BE     5   	     � Title$  AllHostingUnitWindow��5	   	   $	��450��6&   $	��800��63    � 	Resources 5
         hostingUnitViewSource��%   &	        �� 5   
   6   5      .��5      �  � DataContext# [  6   .+�5   
   �� $
��Left=�6   $	��100��6+   $	��Top=�68   $	��100��6P   �� 5   
   $��road-trip-compressor.png��6   $��0��62   $��15��6?   $��2��6Q    J� Opacity$	 0.5Q�6e   $��	0,0,0,0.2q�6s   $
��Fill=�6�   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ hostingUnitDataGrid��5         RowDetailsVisibilityMode$ VisibleWhenSelected=�60   $��20,82,0,178q�6_      EnableRowVirtualization .    AutoGenerateColumns .  ��6t   ��    Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      -   5        adultsColumn��,  &System.Windows.Controls.DataGridColumn	   Width5  /System.Windows.Controls.DataGridLengthConverter$	 SizeToHeader 5   ;   
   Header$
 adults��6P   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6`   �� *adults+  5      -   5        
areaColumn��$	 90 5   9   $

 area��6D    6R   �� *area+4  .System.Windows.Controls.DataGridCheckBoxColumn  5      -   5        childrenAttractionsColumn��$	 SizeToHeader 5   L   $
 children Attractions��6a    6   �� *childrenAttractions+  5      -   5        gardenColumn��$	 SizeToHeader 5   ?   $
 garden��6T    6d   �� *garden+  5      -   5        hostingUnitKeyColumn��$		 120 5   C   $
 Hosting Unit Key��6O    6i   �� *HostingUnitKey+  5      -   5        hostingUnitNameColumn��$		 120 5   D   $
 Hosting Unit Name��6P    6k   �� *HostingUnitName+  5      -   5        jaccuziColumn��$	 SizeToHeader 5   @   $
 jaccuzi��6U    6f   �� *	jaccuzi+  5      -	   5        
kidsColumn��$	 SizeToHeader 5   9   $

 kids��6N    6\   �� *kids+  5      -
   5        
poolColumn��$	 SizeToHeader 5   =   $

 pool��6R    6`   �� *pool+  5      -   5        starsColumn��$	 SizeToHeader 5   :   $
 stars��6O    6^   �� *stars+  5      -   5        subAreaColumn��$	 90 5   <   $
 sub Area��6G    6Y   �� *	subArea+5       5"      5#      