   M S B A M L   `   `   `  ����  Browser    Browser.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     6F     � Title$&   Meow Cats Playground Web Browser��5   	   $	��640��62   $��1014.686��6?    � 
ResizeMode$ CanMinimize=�6P    � WindowStyle$
 None=�6i    � 	Resources 5         Welcome �� TargetProperty �� 
TargetName9  3System.Windows.Media.Animation.EasingDoubleKeyFrame O� KeyTime O� Value��%�  &	        �� 5   
   .��5      U� $U O(UIElement.RenderTransform).(TransformGroup.Children)[3].(TranslateTransform.X)�6,   $ welcome��6�   .\�5	        $ 0��6'   $ -340.598Q�63     5
      $ 0:0:0.7��6'   $ -51.494Q�69     5      $ 0:0:1.6��6'   $ 28.69Q�69   5      U� 5      $U O(UIElement.RenderTransform).(TransformGroup.Children)[3].(TranslateTransform.Y)�6,   $ welcome��6�   .\�5        $ 0��6'   $ -5.885Q�63     5      $ 0:0:0.7��6'   $ 0Q�69     5      $ 0:0:1.6��6'   $ -0.736Q�69   5      U� 5      $ (UIElement.Opacity)�6,   $ welcome��6\   .\�5        $ 0��6'   $	 0.1Q�63     5      $ 0:0:0.7��6'   $	 0.5Q�69     5      $ 0:0:1.6��6'   $ 1Q�69   5      U� 5      $ (UIElement.Opacity)�6,   $ message1��6\   .\�5        $ 0��6'   $ 0Q�63     5      $ 0:0:1.5��6'   $ 0Q�69     5      $ 0:0:2.3��6'   $ 1Q�69   5      U� 5      $ (UIElement.Opacity)�6,   $ games��6\   .\�5        $ 0��6'   $ 0Q�63     5      $ 0:0:1.6��6'   $ 1Q�69   5      U� 5       $ (UIElement.Opacity)�6,   $ videos��6\   .\�5!        $ 0��6'   $ 0Q�63     5"      $ 0:0:1.6��6'   $ 1Q�69   5#      U� 5$      $ (UIElement.Opacity)�6,   $ music��6\   .\�5%        $ 0��6'   $ 0Q�63     5&      $ 0:0:1.6��6'   $ 1Q�69   5'      U� 5(      $ (UIElement.Opacity)�6,   $ learning��6\   .\�5)        $ 0��6'   $ 0Q�63     5*      $ 0:0:1.6��6'   $ 1Q�69   5+      U� 5,      $ (UIElement.Opacity)�6,   $
 back��6\   .\�5-        $ 0��6'   $ 0Q�63     5.      $ 0:0:1.6��6'   $ 1Q�69   5/      U� 50      $ (UIElement.Opacity)�6,   $ forward��6\   .\�51        $ 0��6'   $ 0Q�63     52      $ 0:0:1.6��6'   $ 1Q�69   53      U� 54      $ (UIElement.Opacity)�6,   $ urlbar��6\   .\�55        $ 0��6'   $ 0Q�63     56      $ 0:0:1.6��6'   $ 1Q�69   57      U� 58      $ (UIElement.Opacity)�6,   $ go��6\   .\�59        $ 0��6'   $ 0Q�63     5:      $ 0:0:1.6��6'   $ 1Q�69   5;      U� 5<      $ (UIElement.Opacity)�6,   $ refresh��6\   .\�5=        $ 0��6'   $ 0Q�63     5>      $ 0:0:1.6��6'   $ 1Q�69   5?      U� 5@      $ (UIElement.Opacity)�6,   $ recentplacesrectangle��6\   .\�5A        $ 0��6'   $ 0Q�63     5B      $ 0:0:1.6��6'   $ 1Q�69   5C      U� 5D      $ (UIElement.Opacity)�6,   $ norecent��6\   .\�5E        $ 0��6'   $ 0Q�63     5F      $ 0:0:1.6��6'   $ 1Q�69   5G      U� 5H      $ (UIElement.Opacity)�6,   $ bookmark��6\   .\�5I        $ 0��6'   $ 0Q�63     5J      $ 0:0:1.6��6'   $ 1Q�69   5K      U� 5L      $ (UIElement.Opacity)�6,   $ nobookmarks��6\   .\�5M        $ 0��6'   $ 0Q�63     5N      $ 0:0:1.6��6'   $ 1Q�69   5O      U� 5P      $ (UIElement.Opacity)�6,   $ settings��6\   .\�5Q        $ 0��6'   $ 0Q�63     5R      $ 0:0:1.6��6'   $ 1Q�69   5S      U� 5T      $ (UIElement.Opacity)�6,   $  recentplacesrectangle_Copy��6\   .\�5U        $ 0��6'   $ 0Q�63     5V      $ 0:0:1.6��6'   $ 1Q�69   5W      U� 5X      $ (UIElement.Opacity)�6,   $! recentplacesrectangle_Copy1��6\   .\�5Y        $ 0��6'   $ 0Q�63     5Z      $ 0:0:1.6��6'   $ 1Q�69   5[      U� 5\      $ (UIElement.Opacity)�6,   $! recentplacesrectangle_Copy2��6\   .\�5]        $ 0��6'   $ 0Q�63     5^      $ 0:0:1.6��6'   $ 1Q�69   5_      U� 5`      $ (UIElement.Opacity)�6,   $ 	rectangle��6\   .\�5a        $ 0��6'   $ 0Q�63     5b      $ 0:0:1.6��6'   $ 1Q�69   5c      U� 5d      $ (UIElement.Opacity)�6,   $ 
rectangle1��6\   .\�5e        $ 0��6'   $ 0Q�63     5f      $ 0:0:1.6��6'   $ 1Q�69   5g      U� 5h      $ (UIElement.Opacity)�6,   $ 
rectangle2��6\   .\�5i        $ 0��6'   $ 0Q�63     5j      $ 0:0:1.6��6'   $ 1Q�69   5k      U� 5l      $ (UIElement.Opacity)�6,   $ 
rectangle3��6\   .\�5m        $ 0��6'   $ 0Q�63     5n      $ 0:0:1.6��6'   $ 1Q�69   5o      U� 5p      $ (UIElement.Opacity)�6,   $ 
rectangle4��6\   .\�5q        $ 0��6'   $ 0Q�63     5r      $ 0:0:1.6��6'   $ 1Q�69   5s      U� 5t      $ (UIElement.Opacity)�6,   $ 
rectangle5��6\   .\�5u        $ 0��6'   $ 0Q�63     5v      $ 0:0:1.6��6'   $ 1Q�69   5w      U� 5x      $ (UIElement.Opacity)�6,   $ 
rectangle6��6\   .\�5y        $ 0��6'   $ 0Q�63     5z      $ 0:0:1.6��6'   $ 1Q�69   5{      U� 5|      $ (UIElement.Opacity)�6,   $ 
rectangle7��6\   .\�5}        $ 0��6'   $ 0Q�63     5~      $ 0:0:1.6��6'   $ 1Q�69   5      U� 5�      $ (UIElement.Opacity)�6,   $ 
rectangle8��6\   .\�5�        $ 0��6'   $ 0Q�63     5�      $ 0:0:1.6��6'   $ 1Q�69   5�      U� 5�      $ (UIElement.Opacity)�6,   $ 
rectangle9��6\   .\�5�        $ 0��6'   $ 0Q�63     5�      $ 0:0:1.6��6'   $ 1Q�69   5�      U� 5�      $ (UIElement.Opacity)�6,   $ rectangle10��6\   .\�5�        $ 0��6'   $ 0Q�63     5�      $ 0:0:1.6��6'   $ 1Q�69   5�      U� 5�      $ (UIElement.Opacity)�6,   $ rectangle11��6\   .\�5�        $ 0��6'   $ 0Q�63     5�      $ 0:0:1.6��6'   $ 1Q�69   5�      U� 5�      $ (UIElement.Opacity)�6,   $ rectangle12��6\   .\�5�        $ 0��6'   $ 0Q�63     5�      $ 0:0:1.6��6'   $ 1Q�69   5�      U� 5�      $ (UIElement.Opacity)�6,   $ rectangle13��6\   .\�5�        $ 0��6'   $ 0Q�63     5�      $ 0:0:1.6��6'   $ 1Q�69   5�      U� 5�      $ (UIElement.Opacity)�6,   $ rectangle14��6\   .\�5�        $ 0��6'   $ 0Q�63     5�      $ 0:0:1.6��6'   $ 1Q�69   5�      U� 5�      $ (UIElement.Opacity)�6,   $ rectangle15��6\   .\�5�        $ 0��6'   $ 0Q�63     5�      $ 0:0:1.6��6'   $ 1Q�69   5�      U� 5�      $ (UIElement.Opacity)�6,   $ rectangle16��6\   .\�5�        $ 0��6'   $ 0Q�63     5�      $ 0:0:1.6��6'   $ 1Q�69   5�      U� 5�      $ (UIElement.Opacity)�6,   $ rectangle17��6\   .\�5�        $ 0��6'   $ 0Q�63     5�      $ 0:0:1.6��6'   $ 1Q�69   5�      U� 5�      $ (UIElement.Opacity)�6,   $ rectangle18��6\   .\�5�        $ 0��6'   $ 0Q�63     5�      $ 0:0:1.6��6'   $ 1Q�69   5�      U� 5�      $ (UIElement.Opacity)�6,   $ rectangle19��6\   .\�5�        $ 0��6'   $ 0Q�63     5�      $ 0:0:1.6��6'   $ 1Q�69   5�      U� 5�      $ (UIElement.Opacity)�6,   $ rectangle20��6\   .\�5�        $ 0��6'   $ 0Q�63     5�      $ 0:0:1.6��6'   $ 1Q�69   5�      U� 5�      $ (UIElement.Opacity)�6,   $ rectangle21��6\   .\�5�        $ 0��6'   $ 0Q�63     5�      $ 0:0:1.6��6'   $ 1Q�69   5�      U� 5�      $ (UIElement.Opacity)�6,   $ rectangle22��6\   .\�5�        $ 0��6'   $ 0Q�63     5�      $ 0:0:1.6��6'   $ 1Q�69   5�      U� 5�      $ (UIElement.Opacity)�6,   $ rectangle23��6\   .\�5�        $ 0��6'   $ 0Q�63     5�      $ 0:0:1.6��6'   $ 1Q�69   5�      U� 5�      $ (UIElement.Opacity)�6,   $ bookmarksrectangle��6\   .\�5�        $ 0��6'   $ 0Q�63     5�      $ 0:0:1.6��6'   $ 1Q�69   5�      U� 5�      $ (UIElement.Opacity)�6,   $ urlmask��6\   .\�5�        $ 0��6'   $ 0Q�63     5�      $ 0:0:1.6��6'   $	 0.5Q�69   5�      5�      5�       � Triggers 5�      :� 5�   
   	 :� RoutedEvent$	 FrameworkElement.Loaded��6   .[�5�      �� #��[  6   5�      .��5�      � -   5        
 �Name$
 mainGrid��5�      .+�5�   
   �� -   5         ��Name$ settingsRectangle��5�   t   $
��Left=�6   $	��295��6/   $��
33,137,0,0q�6<   $	��Top=�6P   $	��948��6h   $y�	Collapsed=�6�   ��5�      �� 5�       �� EndPoint$ 0.5,1&�6&    �� 
StartPoint$ 0.5,0&�67   .��5�      �  � Color$ White��6#    � Offset$ 0.998Q�61   � 5�      $ 	#FF49FEAC��6#   $ 0.002Q�65   5�      5�      �� 5�   
   -   5        $ rectangle20��5�      $
��Left=�6)   $	��130��6D   $	��Top=�6Q   $	��129��6i   $��880,524,0,-14q�6u   ��5�      
� 5�      .��5�      � $ 	#FF32F825��6#   $ 0Q�65   � 5�      $ 	#00EBF39D��6#   $ 1Q�65   5�      5�      �� 5�   
   -   5        $ rectangle21��5�      $
��Left=�6)   $	��130��6D   $	��Top=�6Q   $	��129��6i   $��789,538,0,-28q�6u   ��5�      
� 5�      .��5�      � $ 	#FFC9E82C��6#   $ 0Q�65   � 5�      $ 	#001FEFDE��6#   $ 1Q�65   5�      5�      �� 5�   
   -   5        $ rectangle22��5�      $
��Left=�6)   $	��130��6D   $	��Top=�6Q   $	��129��6i   $��866,570,0,-60q�6u   ��5�      
� 5�      .��5�      � $ 	#FF2CCEE8��6#   $ 0.004Q�65   � 5�      $ 	#00E183F9��6#   $ 1Q�65   5�      5�      �� 5�   
   -   5        $ rectangle23��5�      $
��Left=�6)   $	��130��6D   $	��Top=�6Q   $	��129��6i   $��710,555,0,-45q�6u   ��5�      
� 5�      .��5�      � $ 	#FF87F098��6#   $ 0Q�65   � 5�      $ 	#00EF1FDB��6#   $ 1Q�65   5�      5�      �� 5�   
   -   5        $ 	rectangle��5�      $
��Left=�6'   $	��130��6B   $	��Top=�6O   $	��129��6g   $��-58,437,0,0q�6s   ��5�      
� 5�      .��5�      � $ 	#FFF676EB��6#   $ 0Q�65   � 5�      $ 	#00FBFBFB��6#   $ 0.837Q�65   5�      5      �� 5  
   -   5        $ 
rectangle1��5     $
��Left=�6(   $	��130��6C   $	��Top=�6P   $	��129��6h   $��949,440,-63.5,0q�6t   ��5     
� 5     .��5     � $ 	#FFF676EB��6#   $ 0Q�65   � 5     $ 	#00FBFBFB��6#   $ 0.837Q�65   5     5     �� 5	  
   -	   5        $ 
rectangle2��5	     $
��Left=�6(   $	��130��6C   $	��Top=�6P   $	��129��6h   $��938,492,-52.5,0q�6t   ��5
     
� 5     .��5     � $ 	#FF7681F6��6#   $ 0Q�65   � 5     $ 	#009DD0F3��6#   $ 1Q�65   5     5     �� 5  
   -
   5        $ 
rectangle3��5     $
��Left=�6(   $	��130��6C   $	��Top=�6P   $	��129��6h   $��923,545,-37.5,-35q�6t   ��5     
� 5     .��5     � $ 	#FF25F5F8��6#   $ 0Q�65   � 5     $ 	#00F39DEB��6#   $ 1Q�65   5     5     �� 5  
   -   5        $ 
rectangle4��5     $
��Left=�6(   $	��130��6C   $	��Top=�6P   $	��129��6h   $��637,547,0,-37q�6t   ��5     
� 5     .��5     � $ 	#FF87F098��6#   $ 0Q�65   � 5     $ 	#00ECE328��6#   $ 1Q�65   5     5      �� 5!  
   -   5        $ 
rectangle5��5!     $
��Left=�6(   $	��130��6C   $	��Top=�6P   $	��129��6h   $��559,547,0,-37q�6t   ��5"     
� 5#     .��5$     � $ 	#FF87F098��6#   $ 0Q�65   � 5%     $ 	#0046EC28��6#   $ 1Q�65   5&     5(     �� 5)  
   -   5        $ 
rectangle6��5)     $
��Left=�6(   $	��130��6C   $	��Top=�6P   $	��129��6h   $��145,545,0,-35q�6t   ��5*     
� 5+     .��5,     � $ 	#FF87F098��6#   $ 0Q�65   � 5-     $ 	#0046EC28��6#   $ 1Q�65   5.     50     �� 51  
   -   5        $ 
rectangle7��51     $
��Left=�6(   $	��130��6C   $	��Top=�6P   $	��129��6h   $��466,545,0,-35q�6t   ��52     
� 53     .��54     � $ 	#FFFFD560��6#   $ 0Q�65   � 55     $ 	#00F39DEB��6#   $ 1Q�65   56     58     �� 59  
   -   5        $ 
rectangle8��59     $
��Left=�6(   $	��130��6C   $	��Top=�6P   $	��129��6h   $��530,570,0,-60q�6t   ��5:     
� 5;     .��5<     � $ 	#FFF6A9F7��6#   $ 0.002Q�65   � 5=     $ 0.996Q�6#   $ 	#00F8BDF9��62   5>     5@     �� 5A  
   -   5        $ 
rectangle9��5A     $
��Left=�6(   $	��130��6C   $	��Top=�6P   $	��129��6h   $��409,551,0,-41q�6t   ��5B     
� 5C     .��5D     � $ 	#FF87F098��6#   $ 0Q�65   � 5E     $ 	#00ECE328��6#   $ 1Q�65   5F     5H     �� 5I  
   -   5        $ rectangle10��5I     $
��Left=�6)   $	��130��6D   $	��Top=�6Q   $	��129��6i   $��332,547,0,-37q�6u   ��5J     
� 5K     .��5L     � $ 	#FF87F098��6#   $ 0Q�65   � 5M     $ 	#00EFA41F��6#   $ 1Q�65   5N     5P     �� 5Q  
   -   5        $ rectangle11��5Q     $
��Left=�6)   $	��130��6D   $	��Top=�6Q   $	��129��6i   $��322,563,0,-53q�6u   ��5R     
� 5S     .��5T     � $ 	#FFF6A9F7��6#   $ 0.002Q�65   � 5U     $ 0.996Q�6#   $ 	#00F8BDF9��62   5V     5X     �� 5Y  
   -   5        $ rectangle12��5Y     $
��Left=�6)   $	��130��6D   $	��Top=�6Q   $	��129��6i   $��247,548,0,-38q�6u   ��5Z     
� 5[     .��5\     � $ 	#FF87F098��6#   $ 0Q�65   � 5]     $ 	#00EF1FDB��6#   $ 1Q�65   5^     5`     �� 5a  
   -   5        $ rectangle13��5a     $
��Left=�6)   $	��130��6D   $	��Top=�6Q   $	��129��6i   $��205,555,0,-45q�6u   ��5b     
� 5c     .��5d     � $ 	#FF87F098��6#   $ 0Q�65   � 5e     $ 	#00EFA41F��6#   $ 1Q�65   5f     5h     �� 5i  
   -   5        $ rectangle14��5i     $
��Left=�6)   $	��130��6D   $	��Top=�6Q   $	��129��6i   $��100,555,0,-45q�6u   ��5j     
� 5k     .��5l     � $ 	#FF87F098��6#   $ 0Q�65   � 5m     $ 	#00ECE328��6#   $ 1Q�65   5n     5p     �� 5q  
   -   5        $ rectangle15��5q     $
��Left=�6)   $	��130��6D   $	��Top=�6Q   $	��129��6i   $��71,536,0,-26q�6u   ��5r     
� 5s     .��5t     � $ 	#FFFFD560��6#   $ 0Q�65   � 5u     $ 	#00F39DEB��6#   $ 1Q�65   5v     5x     �� 5y  
   -   5        $ rectangle16��5y     $
��Left=�6)   $	��130��6D   $	��Top=�6Q   $	��129��6i   $��-8,516,0,-6q�6u   ��5z     
� 5{     .��5|     � $ 	#FF32F825��6#   $ 0Q�65   � 5}     $ 	#00EBF39D��6#   $ 1Q�65   5~     5�     �� 5�  
   -   5        $ rectangle17��5�     $
��Left=�6)   $	��130��6D   $	��Top=�6Q   $	��129��6i   $��31,555,0,-45q�6u   ��5�     
� 5�     .��5�     � $ 	#FF87F098��6#   $ 0Q�65   � 5�     $ 	#00F39DEB��6#   $ 1Q�65   5�     5�     �� 5�  
   -   5        $ rectangle18��5�     $
��Left=�6)   $	��130��6D   $	��Top=�6Q   $	��129��6i   $��-48,490,0,0q�6u   ��5�     
� 5�     .��5�     � $ 	#FF7681F6��6#   $ 0Q�65   � 5�     $ 	#009DD0F3��6#   $ 1Q�65   5�     5�     �� 5�  
   -   5        $ rectangle19��5�     $
��Left=�6)   $	��130��6D   $	��Top=�6Q   $	��129��6i   $��-34,553,0,-43q�6u   ��5�     
� 5�     .��5�     � $ 	#FF25F5F8��6#   $ 0Q�65   � 5�     $ 	#00F39DEB��6#   $ 1Q�65   5�     5�     �� 5�  
   -   5        $! recentplacesrectangle_Copy2��5�     $��83��69   $��Bottom=�6E   $��0,0,-0.5,366q�6`   $��70��6v   $��Right=�6�   ��5�     �� 5�     $ 0.5,1&�6&   $ 0.5,0&�67   .��5�     � $ 	#FF49FEAC��6#   $ 0Q�65   � 5�     $ 	#FF25F5F8��6#   $ 1Q�65   5�     5�     �� 5�  
   -   5        $! recentplacesrectangle_Copy1��5�     $��83��69   $��Bottom=�6E   $��0,0,-0.5,283q�6`   $��70��6v   $��Right=�6�   ��5�     �� 5�     $ 0.5,1&�6&   $ 0.5,0&�67   .��5�     � $ 	#FF25F5F8��6#   $ 0Q�65   � 5�     $ 	#FFF19DF3��6#   $ 1Q�65   5�     5�     � 5�  
   -   5        $
 settingsGrid��5�     $
��Left=�6&   $	��267��6A   $	��Top=�6N   $	��513��6f   $��247,146,0,0q�6r   $y�	Collapsed=�6�   .+�5�     �� -   5         ��Name$ printButton��5�     $
��Left=�6+   $	��Top=�6F   $��75��6^   $��75��6i   $��	75,40,0,0q�6u   $��0q�6�    J� Opacity$	 0.9Q�6�   #��[" �6�   .��5�     �� $��Resources/printer.png��6   $��65��67   $��75��6B   5�     �� 5�     -   5        $ accessButton��5�     $
��Left=�6+   $	��Top=�6F   $��75��6^   $��
222,40,0,0q�6i   $��75��6}   $��0q�6�   $	 0.9Q�6�   #��[" �6�   .��5�     �� $��75��6   $��75��6$   $0��*Resources/1416621578_685082-Search-128.png��6/   5�     �� 5�     -    5        $ backgroundButton��5�     $	��Top=�6/   $��75��6G   $��	0,40,75,0q�6R   $��75��6e   $��Right=�6q   $��0q�6�   $	 0.9Q�6�   #��[" �6�   .��5�     �� $��75��6   $��75��6$   $%��Resources/1416621613_photos.png��6/   5�     �� 5�     -!   5        $ bookmarksButton��5�     $��Bottom=�6.   $��75��6I   $��
0,0,363,40q�6T   $��75��6h   $��Right=�6t   $��0q�6�   $	 0.9Q�6�   #��[" �6�   .��5�     �� $��75��6   $��65��6$   $B��<Resources/bookmark_bookmarks_favorite_favorites_star-512.png��6/   5�     �� 5�     -"   5        $ historyButton��5�     $
��Left=�6,   $��Bottom=�6G   $��75��6b   $��
222,0,0,40q�6m   $��75��6�   $��0q�6�   $	 0.9Q�6�   #��[" �6�   .��5�     �� $��75��6   $��65��6$   $2��,Resources/1416621648_ic_history_48px-128.png��6/   5�     �� 5�     -#   5        $ parentalSettings��5�     $
��Left=�6/   $��Bottom=�6J   $��76��6e   $��
363,0,0,40q�6p   $��74��6�   $��0q�6�   $	 0.9Q�6�   #��[" �6�   .��5�     �� $��74��6   $��76��6$   $-��'Resources/1416621667_Live_Messenger.png��6/   5�     �� 5�     $
��Left=�6   $
��Wrap=�63   $	��Top=�6G   $��363,120,0,0q�6_   $��75��6t   $
��Bold"�6   $��Parental Controls��6�    �� TextAlignment$ Center=�6�   �� 5�     $
��Left=�6   $
��Wrap=�63   $	��Top=�6G   $��222,131,0,0q�6_   $��75��6t   $ Center=�6   �� 5�  
   $
��Bold"�6   $�History��6    5�     �� 5�     $
��Left=�6   $
��Wrap=�63   $��	Bookmarks��6G   $	��Top=�6X   $��
75,131,0,0q�6p   $��75��6�   $
��Bold"�6�   $ Center=�6�   �� 5�     $
��Left=�6   $
��Wrap=�63   $��
Background��6G   $	��Top=�6Y   $��
363,19,0,0q�6q   $��75��6�   $
��Bold"�6�   $ Center=�6�   �� 5�     $
��Left=�6   $
��Wrap=�63   $��Accessibility��6G   $	��Top=�6\   $��
222,19,0,0q�6t   $��75��6�   $ Center=�6�   $
��Bold"�6�   �� 5�     $
��Left=�6   $
��Wrap=�63   $��Print��6G   $	��Top=�6T   $��	75,19,0,0q�6l   $��75��6   $
��Bold"�6�   $ Center=�6�   �� 5�     -$   5        $ settingsGridExit��5�     $
��Exit��6/   $
��Left=�6>   $��	0,247,0,0q�6Y   $	��Top=�6l   $��75��6�   6�   5�     � 5�  
   -%   5        $
 parentalControls��5�     $
��Left=�6*   $	��267��6E   $��247,146,0,0q�6R   $	��Top=�6g   $	��513��6   $y�	Collapsed=�6�   .+�5�     �� -&   5        $ blockedSites��5�     $��Blocked Sites��6+   $
��Left=�6C   $��	14,62,0,0q�6^   $	��Top=�6q   $��75��6�    � ToolTip$ A list of Blocked Sites��6�   6�   �� 5�     -'   5        $ 
exitButton��5�     $
��Back��6*   $
��Left=�69   $��
10,245,0,0q�6T   $	��Top=�6h   $��75��6�    J� RenderTransformOrigin$ 
0.52,2.182&�6�   � 5�     .��5�     �� -(   5         ��Name$ safesearchPopupText��5�     
������
����  �6R   5�     �� 5�     -)   5         ��Name$ safeSearchCheckbox��5�     $��Safe Search��63   $
��Left=�6I   $��
17,129,0,0q�6d   $	��Top=�6x   $ Enables a Search Filter��6�   6�   �� 5�     -*   5         ��Name$ 	startTime��5�     $
��Left=�6*   $��23��6E   $��
17,170,0,0q�6Q    �� TextWrapping$
 Wrap=�6e   $��Start��6y   $	��Top=�6�   $��50��6�   {�.  6�   �� 5�     -+   5        $ endTime��5�     $
��Left=�6(   $��23��6C   $��103,170,0,0q�6O   $
 Wrap=�6d   $	��End��6x   $	��Top=�6�   $��50��6�   {�.  6�   �� 5�     $
��Left=�6   $��
76,171,0,0q�63   $
��Wrap=�6G   $��To��6[   $	��Top=�6e   $ -0.526,0.501&�6}   �� 5�     -,   5        $ timeRestrictCheck��5�     $��Time Restriction��62   $
��Left=�6M   $	��Top=�6h   $��
17,150,0,0q�6�   $  Sets a time allowed access��6�   �� 5�     --   5        $��passwordChangeButton��5�     $��Password Change��61   $
��Left=�6K   $	��Top=�6f   $	��105��6~   $��	14,89,0,0q�6�   $ Changes the password��6�   6�   �� 5�     $
��Left=�6   $
��Wrap=�63   $	��Top=�6G   $��43��6_   $	��503��6k   $��25(�6w   $
��Bold"�6�   $ Center=�6�   $��Parental Controls��6�   �� 5�     -.   5        $��safeSearchButton��5�     $��Categories...��6.   $
��Left=�6F   $��115,126,0,0q�6a   $	��Top=�6v   $��75��6�   {�.  6�   � 5�     -/   5        $��blockedSitesGrid��5�     $
��Left=�6+   $	��202��6F   $��
222,43,0,0q�6S   $	��Top=�6g   $	��260��6   $y�	Collapsed=�6�   .+�5�     �� $
��Auto=�6   $
��Left=�6B   $	��202��6]   $��	110,0,0,0q�6j   $	��Top=�6}   $	��150��6�   .��5�     �� -0   5        $��blockedSitesListbox��5�     5�     �� 5�     -1   5        $��addBlockedButton��5�     $	��Add��62   $
��Left=�6@   $��	10,30,0,0q�6[   $	��Top=�6n   $��75��6�   6�   �� 5�     -2   5        $��removeBlockedButton��5�     $��Remove��65   $
��Left=�6F   $��	10,73,0,0q�6a   $	��Top=�6t   $��75��6�   6�   �� 5�     -3   5        $��acceptBlockedButton��5�     $��Close��65   $
��Left=�6E   $��
10,158,0,0q�6`   $	��Top=�6t   $��75��6�   6�   5�     � 5�     -4   5        $��blockURLGrid��5�     $
��Left=�6'   $��61��6B   $	��Top=�6N   $	��179��6f   $��
255,79,0,0q�6r   $y�	Collapsed=�6�   .+�5�     �� -5   5        $��blockURLTextBox��5�     $
��Left=�61   $��23��6L   $��	28,10,0,0q�6X   $
 Wrap=�6k   $��Enter URL to Block��6   $	��Top=�6�   $	��120��6�   .��6�   5�     �� 5�     -6   5        $��blockURLAcceptButton��5�     $��Accept��65   $
��Left=�6F   $��	91,33,0,0q�6a   $	��Top=�6t   $��57��6�   6�   5�     � 5�     -7   5        $��passwordChangeGrid��5�     $
��Left=�6-   $	��169��6H   $	��Top=�6U   $	��249��6m   $��
233,62,0,0q�6y   $y�	Collapsed=�6�   .+�5�     �� -8   5        $��cancelPassword��5�     $��Cancel��6/   $
��Left=�6@   $��149,144,0,0q�6[   $	��Top=�6p   $��75��6�   6�   �� 5�     -9   5        $��acceptPassword��5�     $��Change��6/   $
��Left=�6@   $��
27,144,0,3q�6[   $��75��6o   6z   G� 5�     -:   5        $��oldPassword��5�     $
��Left=�61   $	��Top=�6L   $	��171��6d   $��	27,50,0,0q�6p   G� 5�     -;   5        $��newPassword��5�     $
��Left=�61   $	��Top=�6L   $	��169��6d   $��	27,94,0,0q�6p   �� 5�     -<   5        $��enterOldPassword��5�     $
��Left=�64   $��	27,20,0,0q�6O   $
��Wrap=�6b   $��Enter your old password��6v   $	��Top=�6�   $	��142��6�   �� 5�     -=   5        $��enterNewPassword��5�     $
��Left=�64   $��	27,75,0,0q�6O   $
��Wrap=�6b   $��Enter your new password��6v   $	��Top=�6�   $	��142��6�   5�     5�     � 5�  
   ->   5        $
 passwordEntry��5�     $
��Left=�6'   $	��267��6B   $��247,146,0,0q�6O   $	��Top=�6d   $	��519��6|   $y�	Collapsed=�6�   .+�5�     �� -?   5        $ passwordEnter��5�     $��Login��6,   $
��Left=�6<   $��300,134,0,0q�6W   $	��Top=�6l   $��75��6�   6�   �� 5�     -@   5        $ settingsBack��5�     $��Cancel��6+   $
��Left=�6<   $��0,245.04,0,0q�6W   $	��Top=�6m   $��75��6�   6�   �� 5�     -A   5        $ settingsEnterPassword��5�     $
��Left=�67   $��	44,69,0,0q�6R   $
��Wrap=�6e   $@��:Please enter a valid password to access parental controls.��6y   $	��Top=�6�   $��42��6�   $	��386��6�   $��13.333(�6�   G� 5�     -B   5         G�Name$ passwordEntryBox��5�     $
��Left=�64   $��
48,132,0,0q�6O   $	��Top=�6c   $	��222��6{   $��23��6�   5�     �� 5�  
   -C   5        $ go��5�     $��Go��6   $��0,0,96.5,13q�6*   $��51��6?   $��Bottom=�6K   $��Right=�6w   $��52��6�   $��0q�6�   $��Segoe UI Light)�6�   $��13.333(�6�   ��6�   Z� 6�   �� 5�  
   -D   5        $ urlmask��5�     $
��Left=�6%   $��36��6@   $��10,0,152.5,18q�6L   $	 0.5Q�6c   $��Bottom=�6r   $	��851��6�   
�������6�   �� 5�  
   -E   5        $ urlbar��5�     $��10,0,152.5,18q�6"   $
 Wrap=�69   $��22(�6M   $��36��6[   $��Bottom=�6g   $��Segoe UI Light)�6�    �� MaxLines$ 1��6�   ���	#FFB3FBCB$	 0.5Q�6  $��2q�6"   �� SelectionBrush �	#FF77B4F0$.��(Make a search or enter a website here...��6g  ��6Q  Z� 6g  �� 5�  
   -F   5        $ bookmarksrectangle��5�     $��68��60   $	��Top=�6<   $��
0,0,-1.5,0q�6T   ��5�     �� 5�     $ 0.5,1&�6&   $ 0.5,0&�67   .��5�     � $ 	#FF1AB870��6#   $ 0Q�65   � 5�     $ White��6#   $ 1Q�61   5      5     �� 5  
   -G   5        $ nobookmarks��5     $
��Left=�6)   $��	10,38,0,0q�6D   $
��Wrap=�6W   $��No bookmarks��6k   $	��Top=�6   $��20��6�   $	��120��6�   $��14.667(�6�   $��Segoe UI Light)�6�   �� 5  
   -H   5        $
 back��5     $	��←��6    $F @This will allow you to go back to the previous page you were on.��6,   $
��Left=�6y   $��51��6�   $��	69,0,0,13q�6�   $��Bottom=�6�   $��52��6�   $��0q�6  $��Calibri)�6  $��36(�6+  $y�	Collapsed=�69  ��6�   Z� 69  �� 5  
   -I   5        $ refresh��5     $	��↻��6#   $C =This will allow you to refresh the page you currently are on.��6/   $��Bottom=�6x   $��0,0,118.5,13q�6�   $��51��6�   $��Right=�6�   $��52��6�   $��0q�6  $��24(�6  $y�	Collapsed=�6*  ��6�   Z� 6*  �� 5  
   -J   5        $ bookmark��5     $	��★��6$   $��Right=�60   $	��Top=�6L   $��54��6d   $��
0,26,2.5,0q�6o   $��42��6�   $��0q�6�   #��[" �6�   $��24(�6  $	 0.7Q�6  $; 5Click this to add the current page to your bookmarks.��6'  ��6�   Z� 6'  �� 5  
   -K   5        $ forward��5     $	��→��6$   $
��Left=�60   $��Bottom=�6K   $��52��6f   $��
124,0,0,13q�6q   $��51��6�   $��0q�6�   $��36(�6�   $��Calibri)�6�   $y�	Collapsed=�6�   $ 0.558,0.725&�6  $n hIf you've gone back to a page, this will allow you to go to pages you visited after the page you are on.��6/  ��6�   Z� 6/  �� 5  
   -L   5        $
 home��5     $
��Home��6!   $
��Left=�60   $��Bottom=�6K   $��52��6f   $��	10,0,0,13q�6q   $��51��6�   $��0q�6�   $y�	Collapsed=�6�   $��Segoe UI Light)�6�   $g aClicking this will take you back to the welcome screen where you can view all your tabs and more!��6  ��6�   Z� 6  �� 5	  
   -M   5        $  recentplacesrectangle_Copy��5	     $��83��68   $��Bottom=�6D   $��0,0,-0.5,449q�6_   $��70��6u   $��Right=�6�   ��5     �� 5     $ 0.5,1&�6&   $ 0.5,0&�67   .��5     � $ White��6#   $ 0.002Q�61   � 5     $ 	#FF49FEAC��6#   $ 0.998Q�65   5     5     �� 5  
   -N   5        $ recentplacesrectangle��5     $��83                    ��63   $��Bottom=�6S   $��0,0,-0.5,200q�6n   $��70��6�   $��Right=�6�   ��5     �� 5     $ 0.5,1&�6&   $ 0.5,0&�67   .��5     � $ 	#FFF19DF3��6#   $ 0.019Q�65   � 5     $ 1Q�6#   5     5     �� 5  
   -O   5        $ norecent��5     $� �These are recently opened places. Your last four recently opened pages pop up on here. Your most recent page that was last visited is on the bottom.��6&   $��0,0,3.5,227q�6�   $
��Wrap=�6�   $ Center=�6�   $	��306��6  $��Bottom=�6  $��Right=�6/  $��62��6K  $��16(�6V  $��Segoe UI Light)�6d  $��Italic$�6�  $ 0.5,0.5&�6�  �� 5     �� 5     �� 5     �� 5     �� 5     �� 5      �� 5!     �� 5"     �� 5#     $��Normal$�6   $�No��6   �� 5$     �� 5%     �� 5&     �� 5'     $��Normal$�6   $�Recent��6   �� 5(     �� 5)     �� 5*     �� 5+     $��Normal$�6   $�Places��6   5,     �� 5-  
   -P   5        $ recentButton1��5-     $��r1��6(   $��Right=�65   $��0,0,2.5,449q�6Q   $��Bottom=�6f   $��66��6�   $��83��6�   #��[" �6�   ���	#FF4BB7C9$��0q�6  $��Segoe UI Light)�6/  $y�	Collapsed=�6K  ��6�   Z� 6K  �� 5.  
   -Q   5        $ recentButton2��5.     $��r2��6(   $��Right=�65   $��0,0,2.5,366q�6Q   $��Bottom=�6f   $��66��6�   $��83��6�   #��[" �6�   $��0q�6  $��Segoe UI Light)�6  $y�	Collapsed=�63  ��6�   Z� 63  �� 5/  
   -R   5        $ recentButton3��5/     $��r3��6(   $��Right=�65   $��0,0,2.5,283q�6Q   $��Bottom=�6f   $��66��6�   $��83��6�   #��[" �6�   $��0q�6  $��Segoe UI Light)�6  $y�	Collapsed=�63  ��6�   Z� 63  �� 50  
   -S   5        $ recentButton4��50     $��r4��6(   $��Right=�65   $��0,0,2.5,200q�6Q   $��Bottom=�6f   $��66��6�   $��83��6�   #��[" �6�   $��0q�6  $��Segoe UI Light)�6  $y�	Collapsed=�63  ��6�   Z� 63  � 51  
   -T   5        $
 welcomeScreen��51     $
��Left=�6&   $	��514��6A   $	��Top=�6N   $
��1007��6f   $��5,0,0,0q�6s    � RowDefinitions 52     �� 53     $
��317* �6    �� 54     $
��198* �6     � ColumnDefinitions 56     �� 57     $
��977* �6#   �� 58     $��0* �6#   �� 59     $	��30* �6#   .+�5;     �� -U   5        $ welcome��5;     $��244,176,0,0q�6)   $
��Wrap=�6>   $	��Top=�6R   $��69��6j   $
��Left=�6v   $��282.115��6�   $ 0.5,0.5&�6�   $��Segoe UI Light)�6�   $��48(�6�   z�5<     V� 5=     .~�5>     �� �� 5?     �� 5@     T� 5A     5B     �� 5D  
   $�Welcome!��6   �� 5E  
   �� 5F  
   �� 5G  
   �� 5H  
   �� 5I  
   �� 5J  
   �� 5K  
   �� 5L  
   �� 5M  
   5N     �� 5O     -V   5        $ message1��5O     $	��147��6*   $��310.988,269.384,0,0q�67   $
��Wrap=�6T   $Z��TThere are no currently open tabs. To create a tab, enter something in the bar below.��6h   $	��Top=�6�   $��18.667(�6�   $
��Left=�6�   $��409.241��6	  $ 0.5,0.5&�6  $��Segoe UI Light)�69  �� 5P     -W   5        $ games��5P     $��Games��6$   $
��Left=�64   $��
-5,107,0,0q�6O   #��[" �6c   $	��Top=�6�   $��70��6�   $��85��6�   $��14.667(�6�   $��0q�6�   $	 0.9Q�6�   $��Segoe UI Light)�6  $ Popular games��6  ��5Q     �� 5R     $ 0.5,1&�6*    � MappingMode$ RelativeToBoundingBox=�6;   $ 0.5,0&�6_   .��5S     � $ White��6'   $ 0Q�65   � 5T     $ 	#FF49FEAC��6'   $ 1Q�69   5U     5W     �� 5X     -X   5        $ videos��5X     $��Videos��6%   $
��Left=�66   $��
-5,192,0,0q�6Q   $	��Top=�6e   #��[" �6}   $��70��6�   $��85��6�   $��14.667(�6�   $��0q�6�   $��Segoe UI Light)�6�   $ Popular videos��6  ��5Y     �� 5Z     $ 0.5,1&�6*   $ 0.5,0&�6;   .��5[     � $ 	#FF49FEAC��6'   $ 0Q�69   � 5\     $ 	#FF25F5F8��6'   $ 1Q�69   5]     5_     �� 5`     -Y   5        $ music��5`     $��Music��6$   $
��Left=�64   $��
-5,277,0,0q�6O   #��[" �6c   $	��Top=�6�   $��70��6�   $��85��6�   $��2��6�   $��14(�6�   $��0q�6�   $��Segoe UI Light)�6   $ Popular music��6  ��5a     �� 5b     $ 0.5,1&�6*   $ 0.5,0&�6;   .��5c     � $ 	#FF25F5F8��6'   $ 0Q�69   � 5d     $ 	#FFF19DF3��6'   $ 1Q�69   5e     5g     �� 5h     -Z   5        $ learning��5h     $��Learning��6'   $
��Left=�6:   #��[" �6U   $��-5,45.616,0,0q�6�   $	��Top=�6�   $��70��6�   $��85��6�   $��1��6�   $��14.667(�6�   $��0q�6�   $��Segoe UI Light)�6	  $. (School website and popular learning apps��6%  ��5i     �� 5j     $ 0.5,1&�6*   $ 0.5,0&�6;   .��5k     � $ 	#FFF19DF3��6'   $ 0.019Q�69   � 5l     $ 1Q�6'   5m     5o     5r     �� 5t  
   -[   5        $��tab1rec��5t     ���	#FFF4F4F5$
��Left=�64   $	��218��6O   $��
139,73,0,0q�6\   
���   �$	��Top=�6   $	��374��6�   $y�	Collapsed=�6�   $ 0Q�6�   �� 5u  
   -\   5        $��tab2rec��5u     ���	#FFF4F4F5$
��Left=�64   $	��218��6O   $��
546,74,0,0q�6\   
���   �$	��Top=�6   $	��374��6�   $y�	Collapsed=�6�   $ 0Q�6�   �� 5v  
   -]   5        $��tab3rec��5v     ���	#FFF4F4F5$
��Left=�64   $	��218��6O   $��139,299,0,0q�6\   
���   �$	��Top=�6�   $	��374��6�   $y�	Collapsed=�6�   $ 0Q�6�   �� 5w  
   -^   5        $��tab4rec��5w     ���	#FFF4F4F5$
��Left=�64   $	��218��6O   $��546,299,0,0q�6\   
���   �$	��Top=�6�   $	��374��6�   $y�	Collapsed=�6�   $ 0Q�6�   (  "System.Windows.Controls.WebBrowser  5y  
   -_   5          Name$
 tab1��5y     $
��Left=�6#   $	��200��6>   $��
139,92,0,0q�6K   $	��Top=�6_   $	��343��6w   $y�	Collapsed=�6�   6�     5z  
   -`   5        $
 tab2��5z     $
��Left=�6#   $	��200��6>   $��
546,92,0,0q�6K   $	��Top=�6_   $	��343��6w   $y�	Collapsed=�6�   6�     5{  
   -a   5        $
 tab3��5{     $
��Left=�6#   $	��200��6>   $��139,310,0,0q�6K   $	��Top=�6`   $	��343��6x   $y�	Collapsed=�6�   6�     5|  
   -b   5        $
 tab4��5|     $
��Left=�6#   $	��200��6>   $��546,310,0,0q�6K   $	��Top=�6`   $	��343��6x   $y�	Collapsed=�6�   6�   �� 5}  
   -c   5        $ tab1but��5}     $��1��6"   $, &This is a tab. Click on it to open it.��6.   $
��Left=�6a   $	��Top=�6|   $	��343��6�   $��
139,92,0,0q�6�   $	��200��6�   $ 0Q�6�   $y�	Collapsed=�6#    � Cursor$
  Hand��6:  �� 5~  
   -d   5        $ tab2but��5~     $��2��6"   $, &This is a tab. Click on it to open it.��6.   $
��Left=�6a   $	��Top=�6|   $	��343��6�   $��
546,91,0,0q�6�   $	��200��6�   $ 0Q�6�   $y�	Collapsed=�6$  $
  Hand��6;  �� 5  
   -e   5        $ tab3but��5     $��3��6"   $, &This is a tab. Click on it to open it.��6.   $
��Left=�6a   $	��Top=�6|   $	��343��6�   $��139,317,0,0q�6�   $	��200��6�   $ 0Q�6�   $y�	Collapsed=�6%  $
  Hand��6<  �� 5�  
   -f   5        $ tab4but��5�     $��4��6"   $, &This is a tab. Click on it to open it.��6.   $
��Left=�6a   $	��Top=�6|   $	��343��6�   $��546,317,0,0q�6�   $	��200��6�   $ 0Q�6�   $y�	Collapsed=�6$  $
  Hand��6;  �� 5�  
   -g   5        $ tab1X��5�     $��X��6    $
��Left=�6,   $	��Top=�6G   $��17��6_   $��
482,73,0,0q�6j   $��19��6~   $y�	Collapsed=�6�   $ 0.391,0.078&�6�   6  �� 5�  
   -h   5        $ tab2X��5�     $��X��6    $
��Left=�6,   $	��Top=�6G   $��17��6_   $��
889,73,0,0q�6j   $��19��6~   $y�	Collapsed=�6�   6�   �� 5�  
   -i   5        $ tab3X��5�     $��X��6    $
��Left=�6,   $	��Top=�6G   $��17��6_   $��482,292,0,0q�6j   $��19��6   $y�	Collapsed=�6�   6�   �� 5�  
   -j   5        $ tab4X��5�     $��X��6    $
��Left=�6,   $	��Top=�6G   $��17��6_   $��889,292,0,0q�6j   $��19��6   $y�	Collapsed=�6�   6�   � 5�  
   -k   5        $
 
HeaderGrid��5�     $��26��6#   $	��Top=�6/   $  	ScrollAll��6G   ���	#0000D4DC$��	0,0,0.5,0q�6�   .+�5�     �� -l   5        $ 
ExitButton��5�     $��×��6)   $��Right=�65   $��0,0,0,2q�6Q   $��30��6b   
���   �$
��Bold"�6�   #��[" �6�   $  Arrow��6�   $&  Click this to close the browser.��6  ��6�   Z� 6  �� 5�     -m   5        $ MinimizeButton��5�     $��-��6-   $��Right=�69   $��0,0,30,2q�6U   $��30��6g   $
��Bold"�6r   $��13.333(�6�   #��[" �6�   $  Arrow��6�   $) #Click this to minimize the browser.��6  ��6�   Z� 6  5�     �� 5�  
   -n   5        $ settings��5�     $��Settings��6#   $��51��66   $T NThese are the settings. You can find things such as Parental Controls on here.��6B   $��13.333(�6�   $��Segoe UI Light)�6�   $��
0,0,2.5,13q�6�   $��Bottom=�6�   $ 0.949,0.522&�6�   $��0q�6  $��Right=�63  $��52��6O  ��6Z  Z� 6p  �� 5�  
   -o   5        $��settingslabel��5�     $
��Left=�6)   $��	32,84,0,0q�6D   $
��Wrap=�6W   $y�	Collapsed=�6k   $��Settings��6�   $	��Top=�6�   $��Segoe UI Light)�6�   $��36(�6�   �� 5�  
   -p   5        $��settingsXBut��5�     $��X��6&   $
��Left=�62   $��957,137,0,0q�6M   $	��Top=�6b   $��24��6z   $��0q�6�   $	 0.9Q�6�   #��[" �6�   $y�	Collapsed=�6  5�     5�     