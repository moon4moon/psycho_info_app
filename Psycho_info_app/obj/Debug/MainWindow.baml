   M S B A M L   `   `   `  ����J  FPsycho_info_app, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:Psycho_info_appPsycho_info_app  5   	   E'clr-namespace:Psycho_info_app.ViewModelPsycho_info_app.ViewModel  5   	        Psycho_info_app.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   /localclr-namespace:Psycho_info_app     5   	   =	ViewModel'clr-namespace:Psycho_info_app.ViewModel     5   	     � Title$  	PsychoApp��5	   	   $	��900��5
   	   $
��1440��5   	    � 
ResizeMode$ NoResize=�5   	    � WindowStartupLocation$ CenterScreen=�5   	    � DataContext 5      -  'Psycho_info_app.ViewModel.MainViewModel  5   
   .��5      �� ��5   
   �� 5       �� Color$ #89C2D9��6   ._�5   
   �  � ColumnDefinitions 5      �� 5      $	��280 �6#   �� 5      .+�5      �� $��0��6   ��5      �� 5       �� 
StartPoint$	 0,0&�6*    �� EndPoint$	 0,1&�6;   .��5       �  � Color$ Black��6'   	 � Offset$	 0Q�65   � 5!      $ #012A4A��6'   $		 0.4Q�67   � 5"      $ #012A4A��6'   $
	 0.85Q�67   � 5#      $ Black��6'   $	 1Q�65   5$      .+�5'      �� $	��280��6   
������ ._�5*      �� $��
Psycho App��6    
�������$��30(�5,       $
��Bold"�5-       
 �� TextAlignment$
 Center=�5.       $��Center=�5/       50      	� 52      -   5        $��HomePage��53      $��Strona główna��52         Menu_Button#��[  54       d� 	IsChecked$
 TrueY�55      ��56      �� *HomeVC+	� 58      -   5        $��Dieases��59      $��Choroby��58      #��[  5:      ��5;      �� *DiseasesListVC+	� 5=      -   5        $��	Therapies��5>      $��Terapie��5=      #��[  5?      ��5@      �� *	TherapyVC+	� 5B      -   5        $��Specialists��5C      $��Specialiści��5B      #��[  5D      ��5E      �� *SpecialistsVC+	� 5G      -   5        $��
HealthLife��5H      $��Jak żyć zdrowo��5G      #��[  5I      ��5J      �� *HealthLifeVC+	� 5L      -   5        $��Tests��5M      $��Testy��5L      #��[  5N      ��5O      �� *	TestsVC+	� 5Q      -   5        $��AboutUs��5R      $��O nas��5Q      #��[  5S      ��5T      �� *	AboutUsVC+5U      �� 5W      -   5        $
��Test��5X      $��1��5W      ��5Y      �� *CurrentView+5Z      5[      5\      