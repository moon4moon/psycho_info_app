   M S B A M L   `   `   `  ����J  FPsycho_info_app, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:Psycho_info_appPsycho_info_app  5   	   E'clr-namespace:Psycho_info_app.ViewModelPsycho_info_app.ViewModel  5   	        Psycho_info_app.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   /localclr-namespace:Psycho_info_app     5   	   =	ViewModel'clr-namespace:Psycho_info_app.ViewModel     5   	     � Title$  	PsychoApp��5	   	   $	��900��5
   	   $
��1440��5   	    � 
ResizeMode$ NoResize=�5   	    � WindowStartupLocation$ CenterScreen=�5   	    � DataContext 5      -  'Psycho_info_app.ViewModel.MainViewModel  5   
   .��5      �� ._�5   
   �  � ColumnDefinitions 5      �� 5      $	��280 �6#   �� 5      .+�5      �� $��0��6   ��5      �� 5       �� 
StartPoint$	 0,0&�6*    �� EndPoint$	 0,1&�6;   .��5      �  � Color$ Black��6'    � Offset$ 0Q�65   � 5      $ #012A4A��6'   $	 0.4Q�67   � 5       $ #012A4A��6'   $
 0.85Q�67   � 5!      $ Black��6'   $ 1Q�65   5"      .+�5%      �� $	��280��6   
������ ._�5(      �� $��
Psycho App��6    
�������$��30(�5*       $
��Bold"�5+       	 �� TextAlignment$	 Center=�5,       $��Center=�5-       5.      	� 50      -   5        $��HomePage��51      $��Strona główna��50         Menu_Button#��[  52      
 d� 	IsChecked$

 TrueY�53      ��54      �� *HomeVC+	� 56      -   5        $��Dieases��57      $��Choroby��56      #��[  58      ��59      �� *DiseasesListVC+	� 5;      -   5        $��	Therapies��5<      $��Terapie��5;      #��[  5=      ��5>      �� *	TherapyVC+	� 5@      -   5        $��Specialists��5A      $��Specialiści��5@      #��[  5B      ��5C      �� *SpecialistsVC+	� 5E      -   5        $��
HealthLife��5F      $��Jak żyć zdrowo��5E      #��[  5G      ��5H      �� *HealthLifeVC+	� 5J      -   5        $��Tests��5K      $��Testy��5J      #��[  5L      ��5M      �� *	TestsVC+	� 5O      -   5        $��AboutUs��5P      $��O nas��5O      #��[  5Q      ��5R      �� *	AboutUsVC+5S      �� 5U      -   5        $
��Test��5V      $��1��5U      ��5W      �� *CurrentView+5X      5Y      5Z      