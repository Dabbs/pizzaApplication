   M S B A M L   `   `   `  ����C  ?PizzaApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:PizzaAppPizzaApp  5   	       PizzaApp.PizzaDataView   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (localclr-namespace:PizzaApp     5   	     � Title$  PizzaDataView��5   	   $	��450��6   $��1008.457��6,   .��5	      �  � ColumnDefinitions 5
   
   �� 5      $
��795* �6   �� 5      $	��35* �6   �� 5      $	��89* �6   .+�5   
   �� $
��Left=�6   $	��385��6,   $��	31,24,0,0q�69   $	��Top=�6L   $	��853��6d   $��3��6p   .+�5      &   System.Windows.Controls.DataGrid  -   5          Name$ DataGridXAML��5      $	��333��6-    �� Left$ 10��6:   
 �� Top$ 10��6K   $	��910��6[      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ 
Pizza Name��6)      Width5  /System.Windows.Controls.DataGridLengthConverter$	 100 6W   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6>   �� *Name+6W     5      $ Ham Qty��6)   $ 60 6_    6;   �� *Ingredients.Ham+6_     5      $ 
Cheese Qty��6)   $ 70 6e    6>   �� *Ingredients.Cheese+6e     5      $ 	Bacon Qty��6)   $ 80 6c    6=   �� *Ingredients.Bacon+6c     5      $ Pepperini Qty��6)   $ 85 6k    6A   �� *Ingredients.Pepperoni+6k     5      $ PineApple Qty��6)   $ 85 6k    6A   �� *Ingredients.PineApple+6k     5      $ 
Tomato Qty��6)   $ 86 6e    6>   �� *Ingredients.Tomato+6e     5      $ Cumcumber Qty��6)   $	 100 6k    6A   �� *Ingredients.Cumcumber+6k     5      $ 
Banana Qty��6)   $ 85 6e    6>   �� *Ingredients.Banana+6e     5      $ Sauce��6)   $ 85 6c    69   �� *Ingredients.SauceName+6c     5      $ 
Total Cost��6)    6>   �� *	TotalCost+	 � 	Resources	 5      =  7System.Windows.Controls.Primitives.DataGridColumnHeader
 �� 
TargetType �� Property �� Value��%�   '        �� 5       "
  6   .�5!      ��  � ��
 �����67   �� 5"       � ��$ SemiBold"�67   �� 5#       � ��$ 0,0,1,2q�6<   �� 5$       � ��
 �   �68   5%      5&      5'      �� 5(      -   5        $��closeBtn��5(   S   $��Close��6   $	 739��6%   $	 355��67   $��75��6H   6c   5)      5+      5,      