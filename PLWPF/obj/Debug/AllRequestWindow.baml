   M S B A M L   `   `   `  ����@  <PLWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:PLWPFPLWPF  5   	       PLWPF.AllRequestWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   %localclr-namespace:PLWPF     5   	     � Title$  AllRequestWindow��5   	   $	��450��6"   $	��800��6/   .��5	      �  � RowDefinitions 5
   
   �� 5      $
��335* �6   �� 5      $	��26* �6   �� 5      $	��37* �6   �� 5      $	��18* �6   �� 5      $��4* �6   .+�5   
   �� $
��Left=�6   $	��100��6+   $	��Top=�68   $	��100��6P   �� 5   
   $��road-trip-compressor.png��6   $��0��62    J� Opacity$	 0.5Q�6?   $��-10,-31,0,0q�6M   $
��Fill=�6b   $
��Left=�6q   $	��802��6�   $��5��6�   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ RequestsDataGrid��5         RowDetailsVisibilityMode$ VisibleWhenSelected=�6-   $��
0,56,0,182q�6\      EnableRowVirtualization .    AutoGenerateColumns .  ��6p   ��    Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      -   5        GuestRequestKeyColumn��,  &System.Windows.Controls.DataGridColumn   Width5  /System.Windows.Controls.DataGridLengthConverter$ 90 5   D   	   Header$	 GuestRequestKey��6O   1  +System.Windows.Controls.DataGridBoundColumn
   Binding
 6h   �� *GuestRequestKey+  5      -   5        PrivateNameColumn��$ 50 5   @   $	 PrivateName��6K   
 6`   �� *PrivateName+  5      -   5        FamilyNameColumn��$ SizeToHeader 5   ?   $	 
FamilyName��6T   
 6h   �� *
FamilyName+  5      -   5        MailAddressColumn��$ 50 5   @   $	 MailAddress��6K   
 6`   �� *MailAddress+  5      -   5        StatusRequestColumn��$ 50 5   B   $	 StatusRequest��6M   
 6d   �� *
CreateDate+  5      -   5        RegistrationDateColumn��$ 50 5   E   $	 RegistrationDate��6P   
 6j   �� *RegistrationDate+  5      -   5        EntryDateColumn��$ 50 5   >   $	 	EntryDate��6I   
 6\   �� *	EntryDate+  5      -	   5        ReleaseDateColumn��$ 50 5   @   $	 ReleaseDate��6K   
 6`   �� *ReleaseDate+  5       -
   5        
AreaColumn��$ 50 5    9   $
	 Area��6D   
 6R   �� *Area+  5!      -   5        SubAreaColumn��$ 50 5!   <   $	 SubArea��6G   
 6X   �� *	SubArea+  5"      -   5        
TypeColumn��$ 50 5"   9   $
	 Type��6D   
 6R   �� *Type+  5#      -   5        AdultsColumn��$ 50 5#   ;   $	 Adults��6F   
 6V   �� *Adults+  5$      -   5        ChildrenColumn��$ 50 5$   =   $	 Children��6H   
 6Z   �� *
Children+  5%      -   5        
PoolColumn��$ 50 5%   9   $
	 Pool��6D   
 6R   �� *Pool+  5&      -   5        JacuzziColumn��$ 50 5&   <   $	 Jacuzzi��6G   
 6X   �� *	Jacuzzi+  5'      -   5        GardenColumn��$ 50 5'   ;   $	 Garden��6F   
 6V   �� *Garden+  5(      -   5        ChildrenAttractionsColumn��$ 50 5(   H   $	 ChildrenAttractions��6S   
 6p   �� *ChildrenAttractions+5+      5-      5.      