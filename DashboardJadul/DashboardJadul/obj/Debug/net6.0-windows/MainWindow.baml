   M S B A M L   `   `   `  ����I  EDashboardJadul, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:DashboardJadul.HelperDashboardJadul.Helper  5   	   C&clr-namespace:DashboardJadul.ViewModelDashboardJadul.ViewModel  6;       DashboardJadul.MainWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   5local#clr-namespace:DashboardJadul.Helper     5   	   5vm&clr-namespace:DashboardJadul.ViewModel     6;   -   5          �Name$  ResponsiveWindows��5	   	    � Title$ 
MainWindow��5   	   $	��700��5
   	   $
��1350��5   	   $	��428��5   	    � WindowStyle$
 None=�5   	    � AllowsTransparency$
 True��5   	    � 
ResizeMode$ CanResizeWithGrip=�5   	    � WindowStartupLocation$ CenterScreen=�5   	   
������  � 	Resources 5         BooleanToVisibility��%   &	        �� 5   
   6'   5       � DataContext 5      ,   &DashboardJadul.ViewModel.MainViewModel  5      .��5      � .+�5   
   �� ���#282D33���#3a4149$��5q�5       �� CornerRadius$ 8,8,0,8��5      �� 5!   
   ��6   �� ��5#      �� 5%      	 �� 
TargetType"	 ��6   .�5)      �� 
 �� Property
 � ��  Laptop_Layout �� Value# [ 5*       �� Triggers 5,      �� 50       �� Binding 6&   ��  �� Path$ ActualWidth� �� RelativeSource ��  �� AncestorType
 Window2   ,DashboardJadul.Helper.IsGreaterThanConverter   Instance �� 	Converter# Z  �� ConverterParameter$
 1400�� �� Value True51   &   .a�53      �� 
 � ��  Desktop_Layout# [ 54   %   56      �� 5:       6&   �� $ ActualWidth� �� 
 Window/   )DashboardJadul.Helper.IsLessThanConverter   Instance# Z $
 1200�� True5;   &   .a�5=      �� 
 � ��  Tablet_Landscape_Layout# [ 5>   %   5@      �� 5D       6&   �� $ ActualWidth� �� 
 Window# Z $
 1024�� True5E   &   .a�5G      �� 
 � ��  Tablet_Portrait_Layout# [ 5H   %   5J      �� 5N       6&   �� $ ActualWidth� �� 
 Window# Z $	 812�� True5O   &   .a�5Q      �� 
 � ��  Mobile_Landscape_Layout# [ 5R   %   5T      �� 5X       6&   �� $ ActualWidth� �� 
 Window# Z $	 667�� True5Y   &   .a�5[      �� 
 � ��  Mobile_Portrait_Layout# [ 5\   %   5^      5b      5f      �� 5j   
   ��6   �� y�5k      �� *IsPanelVisible+# [  ��5m      �� 5o      "	 ��6   .�5q      �� 
 � ��  MenuTemplate# [ 5r      5t      5x      �� 5{   
     CloseAppStyle#��[ 5}      ��5{      �� *CloseAppCommand+��5|      ��  �� ElementName$ ResponsiveWindow��5}      5~      5      