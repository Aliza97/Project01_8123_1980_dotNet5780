   M S B A M L   `   `   `  ���� @  <PLWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:PLWPFPLWPF      PLWPF.addOrderWindow   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     %localclr-namespace:PLWPF       � Title$  addOrderWindow��$	��450��$	��800��.���  � RowDefinitions �� $��* ��� $��* ��� $��* ��� $��* ��� $��* ��� $��* ��� $��* ��� $��* � � ColumnDefinitions �� $��* ��� $��* �.+��� $
��Left=�$	��100��$	��Top=�$	��100���� $��road-trip-compressor.png��$��0��$��15��$��2�� J� Opacity$	 0.5Q�$��	0,0,0,0.2q�$
��Fill=��� $��הוספת הזמנה��$��Right=�$��Center=�$	��Top=�$��20(�$��Lucida Calligraphy)�$
��Bold"�$��323,10,331,0q�$��2��$	��146���� $$��מספר יחידת אירוח��$��Right=�$��1��$��1��$��Center=�$��Center=�$��15(�$��Lucida Calligraphy)�$
��Bold"�$��94,16,144,0q�$	��162��$��40���� $"��מספר דרישת לקוח��$��Right=�$��1��$��2��$��Center=�$��Center=�$��15(�$��Lucida Calligraphy)�$
��Bold"�$��83,17,152,10q�$	��165��$��29���� $��מספר הזמנה��$��Right=�$��1��$��3��$��Center=�$��Center=�$��15(�$��Lucida Calligraphy)�$
��Bold"�$��147,17,152,10q�$	��101��$��29���� $��
סטטוס��$��Right=�$��1��$��4��$��Center=�$��Center=�$��15(�$��Lucida Calligraphy)�$
��Bold"�$��181,0,150,0q�$��65���� $��תאריך יצירה��$��Right=�$��1��$��5��$��Center=�$��Center=�$��15(�$��Lucida Calligraphy)�$
��Bold"�$��118,14,152,13q�$	��130���� $��  תאריך הזמנה��$��Right=�$��1��$��6��$��Center=�$��Center=�$��15(�$��Lucida Calligraphy)�$
��Bold"�$��128,16,152,10q�$	��120���� -   $��
הוספה��$��Center=�$��13��$��Center=�$	��144��$��2��$��30��$
��Bold"�$��20(�$��326,20,330,10q�$��2���� -    ��Name$ HostingUnitKey��$��1��$��0��$��23�� �� TextWrapping$
 Wrap=�$	��120��$	 0.6Q����� *HostingUnitKey+�� -   $ GuestRequestKey��$��2��$��0��$��23��$
 Wrap=�$	��120��$	 0.6Q����� *GuestRequestKey+�� -   $ OrderKey��$��3��$��0��$��23��$
 Wrap=�$	��120��$	 0.6Q����� *
OrderKey+�� -    ��Name$ Status��$��4��$��0��$	��120��$��Center=�$��138,4q�$	 0.6Q�����  �� SelectedItem �� *Status+(  "System.Windows.Controls.DatePicker  -     Name$ 
CreateDate��$��0��$��Center=�$��5��$��Center=�$	��120��$	 0.6Q�$��138,21,138,0q�$��32��	   SelectedDate	 �� *
CreateDate+  -   $ 	OrderDate��$��0��$��Center=�$��6��$��Center=�$	��120��$	 0.6Q�$��138,19,138,10q�$��23��	 �� *	OrderDate+