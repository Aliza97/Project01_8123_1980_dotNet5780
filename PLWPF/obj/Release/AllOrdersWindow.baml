   M S B A M L   `   `   `  ���� @  <PLWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:PLWPFPLWPF  = 9BE, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:BE;assembly=BEBE     PLWPF.AllOrdersWindow   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     %localclr-namespace:PLWPF     +BEclr-namespace:BE;assembly=BE       � Title$  AllOrdersWindow��$	��450��$	��800�� � 	Resources    orderViewSource��%   &	        �� .���  � DataContext# [  .+��� $
��Left=�$	��100��$	��Top=�$	��100���� $��road-trip-compressor.png��$��0��$��15��$��2�� J� Opacity$	 0.5Q�$��	0,0,0,0.2q�$
��Fill=�&   System.Windows.Controls.DataGrid  -     Name$ OrdersDataGrid��   RowDetailsVisibilityMode$ VisibleWhenSelected=�$��10,60,10,114q�   EnableRowVirtualization .    AutoGenerateColumns .  ����    Columns 0  *System.Windows.Controls.DataGridTextColumn  -   hostingUnitKeyColumn��,  &System.Windows.Controls.DataGridColumn	   Width5  /System.Windows.Controls.DataGridLengthConverter$	 90 
   Header$
 Hosting Unit Key��1  +System.Windows.Controls.DataGridBoundColumn   Binding �� *HostingUnitKey+  -   orderkeyColumn��$	 90 $
 OrderKey�� �� *
OrderKey+  -   guestrequestkeyColumn��$	 SizeToHeader $
 GuestRequestKey�� �� *GuestRequestKey+  -   statusColumn��$		 130 $
 Status�� �� *Status+  -   createdateColumn��$		 130 $
 
CreateDate�� �� *
CreateDate+  -   orderdateColumn��$		 130 $
 	OrderDate�� �� *	OrderDate+