   M S B A M L   `   `   `  ����@  <PLWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:PLWPFPLWPF  5   	   = 9BE, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:BE;assembly=BEBE 5   	       PLWPF.AllOrdersWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   %localclr-namespace:PLWPF     5   	   +BEclr-namespace:BE;assembly=BE     5   	     � Title$  AllOrdersWindow��5	   	   $	��450��6!   $	��800��6.    � 	Resources 5
         orderViewSource��%   &	        �� 5   
   6   5      .��5      �  � DataContext# [  6   .+�5   
   �� $
��Left=�6   $	��100��6+   $	��Top=�68   $	��100��6P   �� 5   
   $��road-trip-compressor.png��6   $��0��62   $��15��6?   $��2��6Q    J� Opacity$	 0.5Q�6e   $��	0,0,0,0.2q�6s   $
��Fill=�6�   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ OrdersDataGrid��5         RowDetailsVisibilityMode$ VisibleWhenSelected=�6+   $��10,60,10,114q�6Z      EnableRowVirtualization .    AutoGenerateColumns .  ��6p   ��    Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      -   5        hostingUnitKeyColumn��,  &System.Windows.Controls.DataGridColumn	   Width5  /System.Windows.Controls.DataGridLengthConverter$	 90 5   C   
   Header$
 Hosting Unit Key��6N   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6h   �� *HostingUnitKey+  5      -   5        orderkeyColumn��$	 90 5   =   $
 OrderKey��6H    6Z   �� *
OrderKey+  5      -   5        guestrequestkeyColumn��$	 SizeToHeader 5   D   $
 GuestRequestKey��6Y    6r   �� *GuestRequestKey+  5      -   5        statusColumn��$		 130 5   ;   $
 Status��6G    6W   �� *Status+  5      -   5        createdateColumn��$		 130 5   ?   $
 
CreateDate��6K    6_   �� *
CreateDate+  5      -   5        orderdateColumn��$		 130 5   >   $
 	OrderDate��6J    6]   �� *	OrderDate+5      5      5      