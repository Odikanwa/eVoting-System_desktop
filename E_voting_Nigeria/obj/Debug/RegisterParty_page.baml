   M S B A M L   `   `   `  ����K  GE_voting_Nigeria, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:E_voting_NigeriaE_voting_Nigeria  5      )    #E_voting_Nigeria.RegisterParty_page   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      0localclr-namespace:E_voting_Nigeria     5        N� Title$  REGISTER PAGE��5	      .��5      �  � ColumnDefinitions 5   
   �� 5      �� 5      �� 5      �� 5      �� 5      �� 5       � RowDefinitions 5   
   �� 5      �� 5      �� 5      �� 5      �� 5      .+�5   
   �� $��1��6   $��1��6!   $��4��6.   $��3��6B   
�������$��3q�6g   $��0,10,0,0q�6{   ._�5      �� $��0��6   $��0��6)    �� Orientation$ Vertical=�66   .+�5      �� $��0��6   $��0��6(   $��2��65   $
��auto��6I   $
��auto��6W   $	��Top=�6d   $
��Left=�6|   $��Center=�6�   $��PARTY REGISTRATION��6�   ���#FFFFFF���	#FF193605$��Segoe UI Black)�6  $
��Bold"�6!  $��13(�63  $��10,10,10,10q�6A  $��0,0,0,0q�6W  �� 5!      $	��150��6   $	��200��6&   
�������$��Center=�6E   ���#FFFFFF$��2q�6x   $��	0,10,0,20q�6�   ._�5"      �� -   5         ��Name$ 
party_logo��5"      5#      �� 5%      $ 
Horizontal=�6   $��Center=�66   .+�5'      �� $ Vertical=�6!   $��Center=�68   .+�5(      �� $
��auto��6    $
��auto��6.   $	��Top=�6<   $
��Left=�6T   $��0,0,0,0q�6o   $��Center=�6�   $��NAME OF PARTY��6�   ���#FFFFFF���	#FF193605$��Segoe UI Black)�6�   $
��Bold"�6  $��9(�6  $��Bottom=�6$  �� 5)      -   5         ��Name$ 
party_name��5)   "   $��35��66   $	��200��6B   $��Center=�6N   $��Center=�6k   $��Center=�6�   $��	0,0,50,20q�6�   5*      �� 5+      $ Vertical=�6!   $��Center=�68   .+�5,      �� $
��auto��6    $
��auto��6.   $	��Top=�6<   $
��Left=�6T   $��0,0,0,0q�6o   $��Center=�6�   $��PARTY ABBREVIATION��6�   ���#FFFFFF���	#FF193605$��Segoe UI Black)�6�   $
��Bold"�6
  $��9(�6  $��Bottom=�6)  �� 5-      -   5        $ party_abbreviation��5-   "   $��35��6>   $	��200��6J   $��0,0,0,20q�6V   $��Center=�6h   $��Center=�6�   $��Center=�6�   5.      5/      �� 51      $ 
Horizontal=�6   $��Center=�66   .+�53      �� $ Vertical=�6!   $��Center=�68   .+�54      �� $
��auto��6    $
��auto��6.   $	��Top=�6<   $
��Left=�6T   $��0,0,0,0q�6o   $��Center=�6�   $��HEAD OFFICE��6�   ���#FFFFFF���	#FF193605$��Segoe UI Black)�6�   $
��Bold"�6  $��9(�6  $��Bottom=�6"  �� 55      -   5        $ head_office��55   "   $��35��67   $	��200��6C   $��Center=�6O   $��Center=�6l   $��Center=�6�   $��	0,0,50,20q�6�   56      �� 57      $ Vertical=�6!   $��Center=�68   .+�58      �� $
��auto��6    $
��auto��6.   $	��Top=�6<   $
��Left=�6T   $��0,0,0,0q�6o   $��Center=�6�   $��PARTY SLOGAN��6�   ���#FFFFFF���	#FF193605$��Segoe UI Black)�6�   $
��Bold"�6  $��9(�6  $��Bottom=�6#  �� 59      -   5        $ party_slogan��59   "   $��35��68   $	��200��6D   $��0,0,0,20q�6P   $��Center=�6b   $��Center=�6   $��Center=�6�   5:      5;      �� 5=      $ 
Horizontal=�6   $��Center=�66   .+�5?      �� $ Vertical=�6!   $��Center=�68   .+�5@      �� $
��auto��6    $
��auto��6.   $	��Top=�6<   $
��Left=�6T   $��0,0,0,0q�6o   $��Center=�6�   $��PARTY MISSION��6�   ���#FFFFFF���	#FF193605$��Segoe UI Black)�6�   $
��Bold"�6  $��9(�6  $��Bottom=�6$  �� 5A      -   5        $ party_mission��5A   "   $��35��69   $	��200��6E   $��Center=�6Q   $��Center=�6n   $��Center=�6�   $��	0,0,50,10q�6�   5B      �� 5C      $ Vertical=�6!   $��Center=�68   .+�5D      �� $
��auto��6    $
��auto��6.   $	��Top=�6<   $
��Left=�6T   $��0,0,0,0q�6o   $��Center=�6�   $��PARTY VISION��6�   ���#FFFFFF���	#FF193605$��Segoe UI Black)�6�   $
��Bold"�6  $��9(�6  $��Bottom=�6#  �� 5E      -   5        $ party_vision��5E   "   $��35��68   $	��200��6D   $��0,0,0,10q�6P   $��Center=�6b   $��Center=�6   $��Center=�6�   5F      5G      �� 5I      $��40��6   $	��250��6%   $��UPLOAD LOGO��61   $��16(�6G   $��Segoe UI Black)�6U   $��Center=�6q   $��Center=�6�   $��0,0,0,10q�6�   $��2q�6�   ���	#FF193605���#FFFFFF���	#FF1936056�   �� 5J      -   5         ��Name$ enroll_party_button��5J      $��40��6X   $	��250��6d   $��ENROLL PARTY��6p   $��16(�6�   $��Segoe UI Black)�6�   $��Center=�6�   $��Center=�6�   $��0,0,0,10q�6�   ���#FFFFFF���	#FF193605
�������6(  5K      5L      5M      5N      