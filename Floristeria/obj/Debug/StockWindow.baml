   M S B A M L   `   `   `  ����F  BFloristeria, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:FloristeriaFloristeria  5   	       Floristeria.StockWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:Floristeria     5   	     � Title$  Stock��5   	   $	��700��6   $	��600��6$    � WindowStartupLocation$ CenterOwner=�60    � WindowStyle$ 
ToolWindow=�6T   .��5	      �  � RowDefinitions 5
   
   �� 5      $��30 �6   �� 5      $��* �6   �� 5      $��50 �6   .+�5   
   �� -   5        $��txtNombreTienda��5   r   $��0��6   $��Stock tienda��6!   $��Center=�65   $��24(�6R   $
��Bold"�6`   6�   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ dgStocks��5       $��1��6      AutoGenerateColumns .     
IsReadOnly .    CanUserSortColumns .  $��10q�6�   ��6{   ��  �� 
GroupStyle 5      (  "System.Windows.Controls.GroupStyle  5      	   HeaderTemplate	 5      �� 5      .R�5      �� 
���   �$��1q�69   
 �� CornerRadius$
 5��6M    �� Padding$ 2q�6^   ._�5   "   �� $��10q�6-    �� Orientation$ 
Horizontal=�69   .+�5   &   �� $��Tipo ��60   �� 5   &   ��60   ��  �� Path$
 Name��� 5   &   $�� ��60   �� 5   &   ��60   �� $ 	ItemCount��� 5   &   $�� Artículos��60   5   #   5      5      5          Columns 5"      0  *System.Windows.Controls.DataGridTextColumn  5#      ,  &System.Windows.Controls.DataGridColumn   Header$
 Tipo��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$	 100 6L   1  +System.Windows.Controls.DataGridBoundColumn   Binding 63   �� *Tipo+6L     5$      $ Nombre��6%   $ * 6P    65   �� *Nombre+6P     5%      $ Cantidad��6%   $	 100 6k    67   �� *
Cantidad+ �� StringFormat$ {0:n0}��   ElementStyle 5&      �� 5'       �� 
TargetType" ��6    .�5(      ��  �� Property � �� �� Value$ Right=�6F   6X   5)      5+        5,      $ Precio��6%   $	 100 6g    65   �� *Precio+$ {0:n2}�� 5-      �� 5.      " ��6    .�5/      ��  � ��$ Right=�6F   6X   50      52        53      $ Importe��6%   $	 100 6i    66   �� *	Importe+$ {0:n2}�� 54      �� 55      " ��6    .�56      ��  � ��$ Right=�6F   6X   57      59      5;      �� 5<   
   -   5        $��2��5<      $	��100��6   $��10q�6*   $��Aceptar��66   6H   5=      5>      