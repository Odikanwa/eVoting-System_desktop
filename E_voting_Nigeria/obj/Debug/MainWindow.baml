   M S B A M L   `   `   `  ����K  GE_voting_Nigeria, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:E_voting_NigeriaE_voting_Nigeria  5   	   !    E_voting_Nigeria.MainWindow   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   0localclr-namespace:E_voting_Nigeria     5   	     � Icon$  Logo/inec1.ico��5   	    � Title$ 
INEC, 2019��5	   	   $	��450��6   $	��800��6)    � WindowState$ 	Maximized=�65   .��5      � -   5         �Name$ Index��5      ��5   
   �� 5       �� ImageSource$K EC:\Users\OdikanwaMichael\Pictures\evoting photos\main_background2.jpg��6    � BindingGroup 5   
   &   System.Windows.Data.BindingGroup  5       � ColumnDefinitions 5   
   �� 5      $��1* �6   �� 5      $��1* �6   �� 5      $��1* �6    � RowDefinitions 5   
   �� 5      �� 5      �� 5      .+�5#   
   � $��3��6   $��Center=�6$   .+�5$      ��  �� Orientation$ 
Horizontal=�6   .+�5%      �� $?��9C:\Users\OdikanwaMichael\Pictures\evoting photos\nca1.png��6   $��80��6\   $��80��6h   $	��Top=�6s   $��5q�6�   �� 5&      $S��MNIGERIAN ELECTRONIC VOTING SYSTEM (INDEPENDENT NIGERIAN ELECTORAL COMMISSION)��6   $
��Bold"�6r   $��25(�6�   $��Segoe UI Black)�6�   $��Center=�6�   	 �� Padding$	 15, 10, 15, 35q�6�   $	��Top=�6�   $
��auto��6�   5'      5(      �� 5+   
   -   5        
 ��Name$
 system_setup_button��5+      $��0��60   $��2��6@   $	��150��6M   $	��250��6Z   $��	10,0,0,10q�6f   $��Center=�6y   $��Center=�6�   ���	#FF1EA018
�������.��5,      �  5-      �� 5.      $��2* �6'   �� 5/      $��1* �6'    51      �� 52      .+�54      �� $��0��6   $��0��6)   $��80��66   $	��180��6B   $��
SYS. SETUP��6N   $
��Bold"�6c   $��20(�6u   $��Segoe UI Black)�6�   $��Center=�6�   �� 55      -   5         ��Name$ settingsImage��55      $A��;C:\Users\OdikanwaMichael\Pictures\evoting photos\setup1.png��6/   $��1��6u   $��0��6�   $��80��6�   $��80��6�   56      57      �� 5:   
   -   5        $
 cast_vote_button��5:      $��3��6,   $��2��6<   $	��150��6I   $	��250��6V   $��	0,0,10,10q�6b   $��Center=�6u   $��Center=�6�   ���	#FF1EA018
�������.��5;      �  5<      �� 5=      $��2* �6'   �� 5>      $��1* �6'    5@      �� 5A      .+�5C      �� $��0��6   $��0��6)   $��80��66   $	��180��6B   $��	CAST VOTE��6N   $
��Bold"�6b   $��20(�6t   $��Segoe UI Black)�6�   $��Center=�6�   �� 5D      -   5        $ 	voteImage��5D      $A��;C:\Users\OdikanwaMichael\Pictures\evoting photos\vote1.jfif��6+   $��1��6q   $��0��6�   $��80��6�   $��80��6�   5E      5F      5G      5H      