   M S B A M L   `   `   `  ????B  >Weather, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:Weather.ViewModelsWeather.ViewModels  5   	   C&clr-namespace:Weather.Views.ConvertersWeather.Views.Converters  5   	       Weather.Views.SignIn   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   7
viewModels clr-namespace:Weather.ViewModels     5   	   9local1&clr-namespace:Weather.Views.Converters     5   	   -   5          ?Name$  WindowNameTobeClose??5
   	    ? 
ResizeMode$ NoResize=?5	   	    ? Title$ SignIn??5   	   $	??570??6   $	??500??6%    ? 	Resources 5      4   .Weather.Views.Converters.MultiBindingConverter   MultiBindingConverter 
 DelAll ?? Property ?? Value  textBlockStyle ?? Triggers P? Property P? Value??%_  &	        &	      7    5   
   6'   ?? 5   
   .?5      ??  ? ?? 5      ?? 5      .R?5      ? .+?5      ?? $??Create an account??6(   $??Baseline{?6A   8??  6\   5       5      P? 5       ?@J?IsMouseOver$
 true??6=   . ?5   "   ??  ? ??
 ?????6?   5      5      5      5      5      	 ? DataContext	 5       (  "Weather.ViewModels.SignInViewModel  5!   
   .??5$      ?   	gridStyle#??[ 6   
 ? RowDefinitions
 5%   
   ?? 5&      $??1* ?6   6*   ?? 5'      $	??11* ?6   6+   ?? 5(      $??1* ?6   6*    ? ColumnDefinitions 5*   
   ?? 5+      6!   ?? 5,      $
??6.5* ?6   6.   ?? 5-      6!   .+?5/   
   ?? $??1??6   $??1??6%    K? ZIndex$ 1??62   .+?51      ?? $??Sing in??6   $??37(?6'   $??	0,20,0,40q?65   #??[ 6H   ?? 53      $??Enter an username??6   #??[ 61   ? 54      $??65??6   .+?55      ?? -   5         ??Name$ Login??55      $	??200??6)   $??0,0,0,20q?65     textBoxStyle#??[ 6G   56      ?? 58      $??Enter a password??6   #??[ 60   ? 59      $??65??6   .+?5:      G? -   5         G?Name$ PasswordBox??5:      $	??200??63   $??0,0,0,20q?6?     passBoxStyle#??[ 6Q   5;      ? 5=      $??70??6   .+?5>      ??   buttonStyle#??[ 5?      $??Center=?6:   $??Center=?6W   $??Bahnschrift Light)?6r   $	??120??5@      $??33??6!   $??Sing in??6-   $??21(?6?    ? Cursor$
 Hand??6M   $??0,0,0,0q?6[   $??0q?5A      ??5B      ?? *SingInCommand+??5C      `? 5D       `? 	Converter# [  6'   .1?5E      ??  ?? ElementName$ Login??6&   ?? 5F      $ PasswordBox??6&   ?? 5G      $ WindowNameTobeClose??6&   5H      5J      5K      ?? 5M      $
 Hand??6   $	??230??6#   $??30??6/   $??0,40,0,0q?6;   #??[ 6?   ??6N   ?? *CreateAccountCommand+??6w   ?? $ WindowNameTobeClose??6?   5N      ?? 5P   
   $??1??6   $??1??6!   
??????? ?? CornerRadius$ 25??6A    J? Effect 5Q      3  -System.Windows.Media.Effects.DropShadowEffect  5R         
BlurRadius$ 40Q?6#      Color$
 Gray??63      ShadowDepth$ 0Q?6@   5T      5U      5V      