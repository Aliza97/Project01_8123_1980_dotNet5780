   M S B A M L   `   `   `  ���� @  <PLWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:PLWPFPLWPF      PLWPF.AllRequestWindow   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     %localclr-namespace:PLWPF       � Title$  AllRequestWindow��$	��450��$	��800��.���  � RowDefinitions �� $
��335* ��� $	��26* ��� $	��37* ��� $	��18* ��� $��4* �.+��� $
��Left=�$	��100��$	��Top=�$	��100���� $��road-trip-compressor.png��$��0�� J� Opacity$	 0.5Q�$��-10,-31,0,0q�$
��Fill=�$
��Left=�$	��802��$��5��&   System.Windows.Controls.DataGrid  -     Name$ RequestsDataGrid��   RowDetailsVisibilityMode$ VisibleWhenSelected=�$��
0,56,0,182q�   EnableRowVirtualization .    AutoGenerateColumns .  ����    Columns 0  *System.Windows.Controls.DataGridTextColumn  -   GuestRequestKeyColumn��,  &System.Windows.Controls.DataGridColumn   Width5  /System.Windows.Controls.DataGridLengthConverter$ 90 	   Header$	 GuestRequestKey��1  +System.Windows.Controls.DataGridBoundColumn
   Binding
 �� *GuestRequestKey+  -   PrivateNameColumn��$ 50 $	 PrivateName��
 �� *PrivateName+  -   FamilyNameColumn��$ SizeToHeader $	 
FamilyName��
 �� *
FamilyName+  -   MailAddressColumn��$ 50 $	 MailAddress��
 �� *MailAddress+  -   StatusRequestColumn��$ 50 $	 StatusRequest��
 �� *
CreateDate+  -   RegistrationDateColumn��$ 50 $	 RegistrationDate��
 �� *RegistrationDate+  -   EntryDateColumn��$ 50 $	 	EntryDate��
 �� *	EntryDate+  -	   ReleaseDateColumn��$ 50 $	 ReleaseDate��
 �� *ReleaseDate+  -
   
AreaColumn��$ 50 $
	 Area��
 �� *Area+  -   SubAreaColumn��$ 50 $	 SubArea��
 �� *	SubArea+  -   
TypeColumn��$ 50 $
	 Type��
 �� *Type+  -   AdultsColumn��$ 50 $	 Adults��
 �� *Adults+  -   ChildrenColumn��$ 50 $	 Children��
 �� *
Children+  -   
PoolColumn��$ 50 $
	 Pool��
 �� *Pool+  -   JacuzziColumn��$ 50 $	 Jacuzzi��
 �� *	Jacuzzi+  -   GardenColumn��$ 50 $	 Garden��
 �� *Garden+  -   ChildrenAttractionsColumn��$ 50 $	 ChildrenAttractions��
 �� *ChildrenAttractions+