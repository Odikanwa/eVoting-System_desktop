   M S B A M L   `   `   `  ����K  GE_voting_Nigeria, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:E_voting_NigeriaE_voting_Nigeria  5      .    (E_voting_Nigeria.RegisterCandidate_page2   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      0localclr-namespace:E_voting_Nigeria     5        N� Title$  RegisterCandidate_page2��5	      .��5      �  � ColumnDefinitions 5   
   �� 5      �� 5      �� 5      �� 5      �� 5      �� 5       � RowDefinitions 5   
   �� 5      �� 5      �� 5      �� 5      �� 5      .+�5   
   �� $��1��6   $��1��6!   $��4��6.   $��3��6B   
�������$��2q�6g   $��0,50,0,0q�6{   ._�5      �� $��0��6   $��0��6)    �� Orientation$ Vertical=�66   .+�5      �� $��0��6   $��0��6(   $��2��65   $
��auto��6I   $
��auto��6W   $	��Top=�6d   $
��Left=�6|   $��Center=�6�   $��CANDIDATE REGISTRATION��6�   ���#FFFFFF���	#FF193605$��Segoe UI Black)�6	  $
��Bold"�6%  $��13(�67  $��10,10,10,10q�6E  $��0,0,0,20q�6[  �� 5!      -   5         ��Name$ candidatePhoto��5!      $	��150��61   $	��200��6>   
�������$��Center=�6]   ���#FFFFFF$��2q�6�   $��0,0,0,40q�6�   ._�5"      �� -   5         ��Name$ candidate_photo��5"      65   5#      �� 5%      $ 
Horizontal=�6   $��Center=�66   .+�5'      �� $ Vertical=�6!   $��Center=�68   .+�5(      �� $
��auto��6    $
��auto��6.   $	��Top=�6<   $
��Left=�6T   $��0,0,0,0q�6o   $��Center=�6�   $��
FIRST NAME��6�   ���#FFFFFF���	#FF193605$��Segoe UI Black)�6�   $
��Bold"�6  $��9(�6  $��Bottom=�6!  �� 5)      -   5         ��Name$ 
first_name��5)   "   $��35��6O   $	��200��6[   $��Center=�6g   $��Center=�6�   $��Center=�6�   $��	0,0,50,20q�6�   5*      �� 5+      $ Vertical=�6!   $��Center=�68   .+�5,      �� $
��auto��6    $
��auto��6.   $	��Top=�6<   $
��Left=�6T   $��0,0,0,0q�6o   $��Center=�6�   $��SURNAME��6�   ���#FFFFFF���	#FF193605$��Segoe UI Black)�6�   $
��Bold"�6�   $��9(�6  $��Bottom=�6  �� 5-      -   5        $ 	last_name��5-   "   $��35��6N   $	��200��6Z   $��0,0,0,20q�6f   $��Center=�6x   $��Center=�6�   $��Center=�6�   5.      5/      �� 51      $ 
Horizontal=�6   $��0,0,0,10q�66   $��Center=�6H   .+�52      �� -   5         ��Name$ 
party_list��52      $��Center=�6L   $��35��6i   $	��150��6u   $��	0,0,50,10q�6�   $��10q�6�   $��Center=�6�   4  .System.Windows.Automation.AutomationProperties   IsRequiredForForm . 	   HelpText$	 Select Party��6�   .@�53      �� 
 �� 
IsSelected
 . {�.  $��SELECT PARTY��6K   ���	#FF193605$��Segoe UI Black)�6z   $
��Bold"�6�   $��9(�6�   55      �� 56      -   5        $ offices_list��56      $��Center=�6N   $��35��6k   $	��150��6w   $��0,0,0,10q�6�   $��10q�6�   $��Center=�6�    . $	 Select Office��6�   .@�57      �� 
 . {�.  $��SELECT OFFICE��6K   ���	#FF193605$��Segoe UI Black)�6{   $
��Bold"�6�   $��9(�6�   59      5:      �� 5<      $��40��6   $	��250��6%   $��Center=�61   $��Center=�6O   $��0,0,0,10q�6j   ���	#FF011501$	��1.5q�6�   ���	#FF193605
�������.��5=      �  5>      �� 5?      $��2* �6/   �� 5@      $��1* �6/    5B      �� 5C      .+�5E      �� $��0��6!   $��0��61   $��80��6>   $	��200��6J   $��
TAKE PHOTO��6V   $
��Bold"�6k   $��15(�6}   $��Segoe UI Black)�6�   $��Center=�6�   $��Center=�6�   
����������	#FF1936056�   �� 5F      -   5        $ cameraImage��5F       $B��<C:\Users\OdikanwaMichael\Pictures\evoting photos\camera2.jpg��65   $��1��6|   $��0��6�   $��80��6�   $��80��6�   $��Center=�6�   $��Center=�6�   5G      5H      �� 5J      -   5         ��Name$ register_candidate_button��5J      $��40��6=   $	��250��6I   $��REGISTER��6U   $��16(�6h   $��Segoe UI Black)�6v   $��Center=�6�   $��Center=�6�   $��0,0,0,10q�6�   ���#FFFFFF���	#FF193605
�������6  5K      5L      5M      5N      