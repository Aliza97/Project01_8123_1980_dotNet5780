   M S B A M L   `   `   `  ���� @  <PLWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:PLWPFPLWPF  = 9BE, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:BE;assembly=BEBE      PLWPF.AllHostingUnitWindow   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     %localclr-namespace:PLWPF     +BEclr-namespace:BE;assembly=BE       � Title$  AllHostingUnitWindow��$	��450��$	��800�� � 	Resources    hostingUnitViewSource��%   &	        �� .���  � DataContext# [  .+��� $
��Left=�$	��100��$	��Top=�$	��100���� $��road-trip-compressor.png��$��0��$��15��$��2�� J� Opacity$	 0.5Q�$��	0,0,0,0.2q�$
��Fill=�&   System.Windows.Controls.DataGrid  -     Name$ hostingUnitDataGrid��   RowDetailsVisibilityMode$ VisibleWhenSelected=�$��20,82,0,178q�   EnableRowVirtualization .    AutoGenerateColumns .  ����    Columns 0  *System.Windows.Controls.DataGridTextColumn  -   adultsColumn��,  &System.Windows.Controls.DataGridColumn	   Width5  /System.Windows.Controls.DataGridLengthConverter$	 SizeToHeader 
   Header$
 adults��1  +System.Windows.Controls.DataGridBoundColumn   Binding �� *adults+  -   
areaColumn��$	 90 $

 area�� �� *area+4  .System.Windows.Controls.DataGridCheckBoxColumn  -   childrenAttractionsColumn��$	 SizeToHeader $
 children Attractions�� �� *childrenAttractions+  -   gardenColumn��$	 SizeToHeader $
 garden�� �� *garden+  -   hostingUnitKeyColumn��$		 120 $
 Hosting Unit Key�� �� *HostingUnitKey+  -   hostingUnitNameColumn��$		 120 $
 Hosting Unit Name�� �� *HostingUnitName+  -   jaccuziColumn��$	 SizeToHeader $
 jaccuzi�� �� *	jaccuzi+  -	   
kidsColumn��$	 SizeToHeader $

 kids�� �� *kids+  -
   
poolColumn��$	 SizeToHeader $

 pool�� �� *pool+  -   starsColumn��$	 SizeToHeader $
 stars�� �� *stars+  -   subAreaColumn��$	 90 $
 sub Area�� �� *	subArea+