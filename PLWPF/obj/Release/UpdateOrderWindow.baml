   M S B A M L   `   `   `  ���� @  <PLWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:PLWPFPLWPF      PLWPF.UpdateOrderWindow   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     %localclr-namespace:PLWPF       � Title$  UpdateOrderWindow��$	��450��$	��800��.���  � RowDefinitions �� $��* ��� $��* ��� $��* ��� $��* ��� $��* ��� $��* ��� $��* ��� $��* � � ColumnDefinitions �� $��* ��� $��* �.+��� $
��Left=�$	��100��$	��Top=�$	��100���� $��road-trip-compressor.png��$��0��$��8��$��2�� J� Opacity$	 0.5Q�$
��Fill=� J� RenderTransformOrigin$ 0.5,0.5&�$��	1,1,-5,-1q�z�V� .~��� ��  �� AngleX$
 0.26Q��� T�  T� X$ -1.022Q��� $��עדכון הזמנה��$��Right=�$��Center=�$	��Top=�$��20(�$��Lucida Calligraphy)�$
��Bold"�$��326,9,328,0q�$��2��$	��146���� $6��0: תכניסו את מספר דרישת לקוח��$��Right=�$��1��$��1��$��Center=�$��Center=�$��20(�$��Lucida Calligraphy)�$
��Bold"�$��
61,10,22,0q�$	��317��$��46���� $8��2: תכניסו את מספר יחידת אירוח��$��Right=�$��1��$��2��$��Center=�$��Center=�$��20(�$��Lucida Calligraphy)�$
��Bold"�$��	78,5,22,0q�$	��300��$��51���� $-��': תכניסו את מספר הזמנה��$��Right=�$��1��$��3��$��Center=�$��Center=�$��20(�$��Lucida Calligraphy)�$
��Bold"�$��106,10,22,10q�$	��272��$��36���� $��
סטטוס��$��Right=�$��1��$��4��$��Center=�$��Center=�$��15(�$��Lucida Calligraphy)�$
��Bold"�$��106,16,229,10q�$��65���� $��תאריך יצירה��$��Right=�$��1��$��5��$��Center=�$��Center=�$��15(�$��Lucida Calligraphy)�$
��Bold"�$��41,10,229,18q�$	��130���� $��  תאריך הזמנה��$��Right=�$��1��$��6��$��Center=�$��Center=�$��15(�$��Lucida Calligraphy)�$
��Bold"�$��51,10,229,16q�$	��120��$ 0.418,0.386&��� -    ��Name$ HostingUnitKey��$��1��$��0�� �� TextWrapping$
 Wrap=�$	 0.6Q�$��235,10,10,10q����� *HostingUnitKey+�� -   $ GuestRequestKey��$��2��$��0��$
 Wrap=�$	 0.6Q�$��235,10,10,10q����� *GuestRequestKey+�� -   $ OrderKey��$��3��$��0��$
 Wrap=�$	 0.6Q�$��235,10,10,10q����� *
OrderKey+�� -   	 ��Name$	 Status��$��4��$��0��$��Center=�$��271,10,0,10q�$	 0.6Q�$��36������ 
 �� SelectedItem
 �� *Status+(  "System.Windows.Controls.DatePicker  -     Name$ 
CreateDate��$��0��$��Center=�$��5��$��Center=�$	��129��$	 0.6Q�$��271,16,0,10q�$��31��   SelectedDate �� *	birthDate+  -   $ 	OrderDate��$��0��$��Center=�$��6��$��Center=�$	��129��$	 0.6Q�$��269,13,394,10q�$ 1.384,0.015&�$��2��$��29�� �� *	birthDate+�� -   $��
עדכון��$��Center=�$��13��$��Center=�$	��144��$��2��$��30��$
��Bold"�$��20(�$��326,20,330,10q�$��2��