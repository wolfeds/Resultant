   M S B A M L   `   `   `  ����D  @Resultant, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:Resultant	Resultant  5   	       Resultant.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:Resultant     5   	     � Title$  
MainWindow��5   	   $	��800��6   $
��1024��6)   .��5	      ]� .+�5
   
   � $	��Top=�6   .+�5      �� -   5         ��Name$ textBlockToDateTime��5   P   $��Center=�6   $��Center=�65   6P   �� 5      -   5         ��Name$ buttonRefresh��5      $��Right=�6H   $��	0,10,10,0q�6d   $��Center=�6w   $��75��6�   .��5      �� .+�5      �� $��Refresh��6    5      5      5      &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ dataGrid��5   %      
IsReadOnly . $
��Left=�67   $��
0,0,0,-0.2q�6R      	RowHeight$ 50Q�6f      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Название��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$ * 6V   1  +System.Windows.Controls.DataGridBoundColumn	   Binding	 68   �� 
 �� Path$

 name�6V     5      $ Цена��6%   $ * 6S   	 63   �� $
 volume�6S     5      $ Количество��6%   $ * 6Y   	 69   �� $
 amount�6Y   5      5      5      