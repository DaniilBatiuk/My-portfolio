   M S B A M L   `   `   `  ????B  >Weather, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:Weather.ViewModelsWeather.ViewModels  5   	   C&clr-namespace:Weather.Views.ConvertersWeather.Views.Converters  5   	       Weather.MainWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   7
viewModels clr-namespace:Weather.ViewModels     5   	   9local1&clr-namespace:Weather.Views.Converters     5   	   -   5          ?Name$  WindowNameTobeClose??5
   	    ? 
ResizeMode$ NoResize=?5	   	    ? Title$ 
MainWindow??5   	   $	??670??6   $	??500??6)    ? 	Resources 5      4   .Weather.Views.Converters.MultiBindingConverter   MultiBindingConverter 
 DelAll ?? Property ?? Value  textBlockStyle ?? Triggers P? Property P? Value??%f  &	        &	      7    5   
   6'   ?? 5   
   .?5      ??  ? ?? 5      ?? 5      .R?5      ? .+?5      ?? $??Already have an account???6(   $??Baseline{?6H   8??  6c   5       5      P? 5       ?@J?IsMouseOver$
 true??6=   . ?5   "   ??  ? ??
 ?????6?   5      5      5      5      5      	 ? DataContext	 5!      .  (Weather.ViewModels.RegistrationViewModel  5"   
   .??5%      ?   	gridStyle#??[ 6   
 ? RowDefinitions
 5&   
   ?? 5'      $??1* ?6   6*   ?? 5(      $	??12* ?6   6+   ?? 5)      $??1* ?6   6*    ? ColumnDefinitions 5+   
   ?? 5,      $??1* ?6   6,   ?? 5-      $
??6.5* ?6   6.   ?? 5.      $??1* ?6   6,   .+?50   
   ?? $??1??6   $??1??6%    K? ZIndex$ 1??62   .+?52      ?? $??Create Account??6   $??37(?6.   $??	0,20,0,40q?6<   #??[ 6O   ?? 54      $??Enter an username??6   #??[ 61   ? 55      $??65??6   .+?56      ?? -   5         ??Name$ Login??56      $	??200??6)   $??0,0,0,20q?65     textBoxStyle#??[ 6G   57      ?? 59      $??Create a password??6   #??[ 61   ? 5:      $??65??6   .+?5;      G? -   5         G?Name$ PasswordBox??5;      $	??200??63   $??0,0,0,20q?6?     passBoxStyle#??[ 6Q   5<      ?? 5>      $??Confirm a password??6   #??[ 62   ? 5?      $??65??6   .+?5@      G? -   5        $ ConfirmationPasswordBox??5@      $	??200??6?   $??0,0,0,20q?6K   #??[ 6]   5A      ? 5C      $??70??6   .+?5D      ??   buttonStyle#??[ 5E      $??Center=?6:   $??Center=?6W   $??Bahnschrift Light)?6r   $	??120??5F      $??33??6!   $??Register??6-   $??21(?6@    ? Cursor$
 Hand??6N   $??0,0,0,0q?6\   $??0q?5G      ??5H      ?? *AddPlayerCommand+??5I      `? 5J       `? 	Converter# [  6'   .1?5K      ??  ?? ElementName$ Login??6&   ?? 5L      $ PasswordBox??6&   ?? 5M      $ ConfirmationPasswordBox??6&   ?? 5N      $ WindowNameTobeClose??6&   5O      5Q      5R      ?? 5S      $	??230??6   $??30??6"   $??0,40,0,0q?6.   $
 Hand??6@   #??[ 6?   ??6N   ?? *SignInCommand+??6p   ?? $ WindowNameTobeClose??6?   5T      ?? 5V   
   $??1??6   $??1??6!   
??????? ?? CornerRadius$ 25??6A    J? Effect 5W      3  -System.Windows.Media.Effects.DropShadowEffect  5X         
BlurRadius$ 40Q?6#      Color$
 Gray??63      ShadowDepth$ 0Q?6@   5Z      5[      5\      