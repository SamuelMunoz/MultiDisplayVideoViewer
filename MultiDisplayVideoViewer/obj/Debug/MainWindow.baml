   M S B A M L   `   `   `  ����  MultiDisplayVideoViewer(    "MultiDisplayVideoViewer.MainWindow   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     6?   -   5          �Name$  Window��5       � Title$$ MultiDisplay Video Viewer 0.8b��5      $	��640��5      $	��480��6    � WindowStyle$ SingleBorderWindow=�6   ���	#FFD7E4C7 � WindowStartupLocation$ CenterScreen=�6S   .��5
      � -   5         �Name$ 
LayoutRoot��5
      .+�5      �� $-��'Bienvenidos a MultiDisplay Video Viewer��6
   $��12,20,11.033,0q�6<   $	��Top=�6T   $��29.333(�6l   $��SketchFlow Print)�6~   $��Normal&�6�   $��Center=�6�   ��6�   Z�  J� Effect 5      3  -System.Windows.Media.Effects.DropShadowEffect  5         
BlurRadius$ 7Q�6      	Direction$	 316Q�6&      Opacity$ 0.925Q�66   	   ShadowDepth$	 9Q�6F   5      �� 5      $��Lista de Archivos��6   $��12,110,109.303,118.04q�6(   .��5      �� -   5        $��lstListaReproducción��5      5      �� 5      -   5        $��txtArchivos��5   T   $��12,84.04,109.303,0q�6   
 �� TextWrapping$

 Wrap=�6(   $	��Top=�6<   6g   �� 5      $>��8Seleccione el archivo (doble click en la caja de texto):��6
   $
��Left=�6M   $��8,58.08,0,0q�6h   $	��Top=�6}   �� 5      -   5        $��
btnAddList��5   �   $��Agregar a la lista��6   $��Right=�6(   $��0,84.04,8,0q�6D   $	��Top=�6Y   $��97.303��6q   ��5      �� 5       �� EndPoint$	 0,1&�6    �� 
StartPoint$	 0,0&�6)   .��5      �  � Color$ 	#FFF3F3F3��6    � Offset$ 0Q�6&   � 5      $ 	#FFEBEBEB��6   $	 0.5Q�6&   � 5      $ 	#FFDDDDDD��6   $	 0.5Q�6&   � 5      $ 	#FFD0D8E4��6   $ 1Q�6&   5      5      �� 5      -   5        $��	btnBorrar��5   {   $��Quitar Elemento��6   $��Right=�6%   $��	0,180,8,0q�6A   $	��Top=�6T   $��97.303��6l   ��5       �� 5!      $	 0,1&�6   $	 0,0&�6)   .��5"      � $ 	#FFF3F3F3��6   $ 0Q�6&   � 5#      $ 	#FFEBEBEB��6   $	 0.5Q�6&   � 5$      $ 	#FFDDDDDD��6   $	 0.5Q�6&   � 5%      $ 	#FFD0D8E4��6   $ 1Q�6&   5&      5(      �� 5)      -   5        $��
btnLimpiar��5)      $��Limpiar Lista��6   $��Right=�6#   $��0,0,8,198.08q�6?   $��97.303��6U   $��Bottom=�6d   ��5*      �� 5+      $	 0,1&�6   $	 0,0&�6)   .��5,      � $ 	#FFF3F3F3��6   $ 0Q�6&   � 5-      $ 	#FFEBEBEB��6   $	 0.5Q�6&   � 5.      $ 	#FFDDDDDD��6   $	 0.5Q�6&   � 5/      $ 	#FFD0D8E4��6   $ 1Q�6&   50      52      �� 53      -   5        $��btnPlayList��53   a   $��
Reproducir��6   $��
146,0,0,59q�6    $��Bottom=�64   $��26.667(�6O   $
��Left=�6t   $	��151��6�   ��54      �� 55      $	 0,1&�6   $	 0,0&�6)   .��56      � $ 	#FFF3F3F3��6   $ 0Q�6&   � 57      $ 	#FFEBEBEB��6   $	 0.5Q�6&   � 58      $ 	#FFDDDDDD��6   $	 0.5Q�6&   � 59      $ 	#FFD0D8E4��6   $ 1Q�6&   5:      5<      �� 5=   
   -	   5        $��Right=�5=      $��34��6,   $��0,0,11.033,8q�68   $��Bottom=�6N   $��34��6i   $��1317083095_info_blue.png��6t   6�   �� 5>   
   -
   5        $��btnStopList��5>   I   $��Detener��6   $��26.667(�6#   $��
0,0,150,59q�65   $��Bottom=�6\   $��Right=�6w   $	��151��6�   ��5?      �� 5@      $	 0,1&�6&   $	 0,0&�65   .��5A      � $ 	#FFF3F3F3��6#   $ 0Q�65   � 5B      $ 	#FFEBEBEB��6#   $	 0.5Q�65   � 5C      $ 	#FFDDDDDD��6#   $	 0.5Q�65   � 5D      $ 	#FFD0D8E4��6#   $ 1Q�65   5E      5G      �� 5H   
   -   5        $��btnRetroceder��5H   1   $��37��6   $��
222,0,0,12q�6   $��Bottom=�6F   $
��Left=�6a   $��75��6|   .��5I      �� $@��:/MultiDisplayVideoViewer;component/Images/1317840280_8.png��6   $��35��6X   5J      �� 5K   
   -   5        $��
btnAvanzar��5K   M   $��37��6   $��Right=�6   $��
0,0,226,12q�69   $��Bottom=�6_   $��75��6z   .��5L      �� $@��:/MultiDisplayVideoViewer;component/Images/1317840278_7.png��6   $��35��6X   5M      5N      5O      