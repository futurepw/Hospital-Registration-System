   M S B A M L   `   `   `  ����P  L医院挂号子系统, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:WpfApp1WpfApp1  5          WpfApp1.Page2   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      'localclr-namespace:WpfApp1     5        N� Title$  Page2��5	      .��5      � 
�������.+�5   
   �� $��IC卡管理系统��6   $
��Left=�6"   $��
308,28,0,0q�6=   $	��Top=�6Q   $��24(�6i   � 5   
   $
��Left=�6   $��81��6*   $��
10,73,0,10q�66   $	��Top=�6J   $	��790��6b   .+�5      �� $��就诊卡卡号：��6   $
��Left=�6%   $��33��6@   $��	10,21,0,0q�6L   $	��Top=�6_   $	��112��6w   $��16(�6�   �� 5      -   5         ��Name$ cardNo��5      $
��Left=�6&   $��23��6A   $��
127,25,0,0q�6M    �� TextWrapping$
 Wrap=�6a   $	��Top=�6u   $	��223��6�   �� 5      $��当前余额：��6   $
��Left=�6$   $��27��6?   $��
373,21,0,0q�6K   $	��Top=�6_   $��73��6w   �� 5      -   5        $��
balancebox��5   �   $
��Left=�6   $��23��61   $��
446,25,0,0q�6=   $
 Wrap=�6Q   $	��Top=�6e   $	��135��6}   
���  ��{�.  6�   �� 5      -   5         ��Name$ 	query_btn��5      $��查询��6(   $
��Left=�65   $��33��6P   $��
620,21,0,0q�6\   $	��Top=�6p   $	��118��6�   6�   5      �� 5   
   $
��Left=�6   $	��265��60   $��
46,154,0,0q�6=   $	��Top=�6Q   $	��690��6i   .@�5      �� $��充值��6   .��5      � ���	#FFE5E5E5 � ColumnDefinitions 5      �� 5      $	��49* �6+   �� 5      $
��635* �6+   .+�5      �� $��充值金额：��6   $
��Left=�6,   $��31��6G   $��	34,37,0,0q�6S   $	��Top=�6f   $	��162��6~   $��2��6�   �� 5      -   5        $ charge_amount_txtbox��5      $
��Left=�6<   $��21��6W   $��
159,39,0,0q�6c   $
 Wrap=�6w   $	��Top=�6�   $	��429��6�    �� 	MaxLength$ 5��6�   $��1��6�   .��6�   5      �� 5      $��用户付款：��6   $
��Left=�6,   $��32��6G   $��	34,68,0,0q�6S   $	��Top=�6f   $	��162��6~   $��2��6�   �� 5       $��	找零：��6   $
��Left=�6*   $��29��6E   $��
34,104,0,0q�6Q   $	��Top=�6e   $	��162��6}   $��2��6�   �� 5!      -   5        $ paid_textbox��5!      $
��Left=�64   $��21��6O   $��
159,73,0,0q�6[   $
 Wrap=�6o   $	��Top=�6�   $	��429��6�   
���  ��$ 5��6�   $��1��6�   �� 5"      -   5        $ change_texbox��5"      $
��Left=�65   $��21��6P   $��159,106,0,0q�6\   $
 Wrap=�6q   $	��Top=�6�   $	��429��6�   
��� � �$ 5��6�   $��1��6�   �� 5#      -   5        $ queryBtn��5#   �   $��充值��6   $
��Left=�6*   $��50��6E   $��227,156,0,0q�6Q   $	��Top=�6f   $	��134��6~   $��16(�6�   $
��Bold"�6�   {�.  $��1��6�   5$      5%      �� 5&      $��退费��6   .��5'      � ���	#FFE5E5E5.+�5(      �� -   5        $��
refund_btn��5(   �   $��退费��6   $
��Left=�6*   $��76��6E   $��
224,74,0,0q�6Q   $	��Top=�6e   $	��221��6}   6�   5)      5*      5+      5,      5-      