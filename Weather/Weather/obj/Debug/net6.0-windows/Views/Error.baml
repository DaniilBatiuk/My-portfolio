   M S B A M L   `   `   `  ????B  >Weather, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:Weather.ViewModelsWeather.ViewModels  5   	       Weather.Views.Error   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   7
viewModels clr-namespace:Weather.ViewModels     5   	   -   5          ?Name$  WindowNameTobeClose??5   	    ? 
ResizeMode$ NoResize=?5	   	    ? Title$ Error??5
   	   $	??320??6   $	??500??6$    ? DataContext 5      )  #Weather.ViewModels.MessageViewModel  5   
   .??5      ?    	gridStyle#??[  6    ? RowDefinitions 5   
   ?? 5      $??1* ?6   6*   ?? 5      $	??12* ?6   6+   ?? 5      $??1* ?6   6*    ? ColumnDefinitions 5   
   ?? 5      6!   ?? 5      $	??19* ?6   6-   ?? 5      6!   .+?5   
   ?? $??1??6   $??1??6%    K? ZIndex$ 1??62   $??10q?6B   .+?5      ?? $ ??/Views/Resources/error.png??6   $??Uniform=?69   $??68??6K   $??62??6W   ?? 5      ???#F33A3A$??	0,10,0,10q?6K   $??70??6^   $
??Wrap=?6j   $??20(?6~     textBlockStyle#??[ 6?   ??6   ?? *ErrorMessage+6?   ?? 5        buttonStyle4#??[ 5      $??Bahnschrift Light)?6;   $??70??5       $??45??6    $??Ok??6,   $??32(?69    ? Cursor$
 Hand??6G   $??0,0,0,0q?6U   ???#F33A3A$??0q?5!      ??5"      ?? *	OkCommand+??5#      ??  ?? ElementName$ WindowNameTobeClose??5$      5%      ?? 5'   
   $??1??6   $??1??6!   
???????	 ?? CornerRadius$	 25??6A   
 J? Effect
 5(      3  -System.Windows.Media.Effects.DropShadowEffect  5)         
BlurRadius$ 40Q?6#      Color$
 Gray??63      ShadowDepth$ 0Q?6@   5+      5,      5-      