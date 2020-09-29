namespace scripts
{
    internal class Program
    {
        private static void Main(string[] args)
        {
        DEVICE: GT - P5210, Android: 4.4
SCREEN_SIZE: 1152x672 179 DPI 2048Mb RAM Memu 2.8.6(softkey)
//===================================================================
// //========================= Параметры ===============================
//=================================================================== 

            // Приоритет автоперехода по аренам (в порядке возрастания, 0 - пропуск, 1 - первая, 2 - вторая и т.д.)
            // <<
            Var #A1 0
Var #A2 1
Var #A3 0
Var #A4 0
Var #A5 0
Var #A6 0
Var #A7 0

// Количество боев на каждой арене перед сменой арены.
Var #An1 0
Var #An2 300
Var #An3 300
Var #An4 300
Var #An5 300
Var #An6 300
Var #An7 0

// Пауза после прохода по всем аренам. (2000 = 1 сек при воспроизведении в Hiro на скорости Х2).
Var #PauseOverArena 0

//===================================================================
// Использовать ульту по кд. (0 - не использовать, 1 - первая, 2 - вторая, 3 - третья).
Var #Ulta 2

// Выбор команды противника (0 - выбор по умолчанию, 1 - верхняя, 2 - средняя, 3 - нижняя).
Var #EnemyLvl 1

//  включение 1 и отключение 0    фильтра по доступности
Var #Nohelp 0


// Выбор боевки (варианты на выбор): 
// 1 - спам легкой атаки (зажимает противника в углу). 
// 2 - стоковая, foxy-jet.
// 3 - Ivawka2649v3
// 4 - Ivawka2649v4 (выбор сообщества)
// 5 - Ivawka2649v5 (эффективна в скрипте Пала-советую её)
// 6 - Ivawka2649v5bl (с блоком версия v5 - советую).
// 7 - Ivawka2649v4bl (4я версия боёвки с блоком)
// 8 - спизжено из "Test_2.2.2.txt".
// 9 - спизжено из "F3s(3).txt" или "W_P_H_3spec_15_0-1.txt".
// 10 - эксперементальная со скрытым блоком
            Var #Boevka 7

//===================================================================
// Помогать союзникам. (1 - да, 0 - нет).
Var #Pomogat 0

// Количество боев между запусками процедуры помощи союзникам.
Var #CtrlNpom 40

// Количество кликов помощи за один заход
Var #CtrlNpomEnd 30

//===================================================================
// Погрешность значений цветов (+- допустимый разброс значений. Чем меньше, тем стабильней). 
// Использовать следует если какое-то действие никогда не срабатывает (например не работает ульта).
            Var #Difference 0

//===================================================================
// Пауза между итерациями в главном цикле программы (влияет на быстродействие в меню).
Var #Pause 300

//===================================================================
// Количество циклов до аварийного нажатия клавиши сброса. (Универсальная защита от сбоев. 
// Закрывает всплывающие окна и производит переподключение при разрыве связи. 
// Для увеличения времени простоя требуется увеличить это число. 
// Не влияет на переподключение при входе с другого устройства, смотри следующий параметр.)
            Var CtrlN 400;
            {
            }

            //===================================================================
            // Время ожидания при входе с другого устройства (2000 = 1 сек при воспроизведении в Hiro на скорости Х2).
            Var #DisconnectPause 0

//===================================================================
// Проверять при аварийных сбросах запущена ли игра. (1 - да, 0 - нет).
            Var #CheckStartApp 0

//===================================================================
// Холостой клик при страте (1 - использовать, 0 - не использовать). 
// "Костыль" для корректного выбора рабочего окна (специально для версий Memu младше 3), 
// убрать использование если при старте с главной страницы скрипт лезет в настройки.
            Var #Holclk 0
// >>

// ==================================================================
// Start
// ==================== Опорные точки и цвета ===========================
// === (Смотрим по последней букве: X - координата x, Y - координата y, С - цвет) ==
// ====================================== В бой!
// <<%
            Var #VboyX1 265
Var #VboyY1 173
Var #VboyC1 -65886

Var #VboyX2 264
Var #VboyY2 80
Var #VboyC2 -65886

// ====================================== Свертка заданий союза. 
Var #SvorX1 600 
Var #SvorY1 555 
Var #SvorC1 23554 

Var #SvorX2 610 
Var #SvorY2 555 
Var #SvorC2 23554 

// ====================================== Конфликт. 
Var #KonfX1 600 
Var #KonfY1 555 
Var #KonfC1 23554 

Var #KonfX2 610 
Var #KonfY2 555 
Var #KonfC2 23554

// ====================================== Экран арен.
Var #ScrArenX1 228
Var #ScrArenY1 187
Var #ScrArenC1 0

Var #ScrArenX2 276
Var #ScrArenY2 171
Var #ScrArenC2 3158065

// ====================================== Экран персонажей 1х1.
Var #ScrPers1X1 171
Var #ScrPers1Y1 323
Var #ScrPers1C1 3092273

Var #ScrPers1X2 59
Var #ScrPers1Y2 509
Var #ScrPers1C2 3092273

Var #ScrPers1X3 313
Var #ScrPers1Y3 198
Var #ScrPers1C3 235354
Var #ScrPers1C31 1712279

// ====================================== Экран персонажей 3х3. 
Var #ScrPers2X1 171
Var #ScrPers2Y1 323
Var #ScrPers2C1 3092273

Var #ScrPers2X2 59
Var #ScrPers2Y2 509
Var #ScrPers2C2 3092273

Var #ScrPers2X3 302
Var #ScrPers2Y3 270
// ==================== помощь.
Var #ScrPers2C3 -919564
// ==================== недоступен.
Var #ScrPers2C31 -1447446

// ==================== Недостаток персов.
Var #ScrPers2X4 325
Var #ScrPers2Y4 368
Var #ScrPers2C4 23553

Var #ScrPers2X5 520
Var #ScrPers2Y5 277

// ==================== помощь (недостаток персов).
Var #ScrPers2C5 235354
// ==================== недоступен (недостаток персов).
Var #ScrPers2C51 1383573

// ====================================== Открылся персонаж при выборе персонажа (произошел сбой).
Var #PersX1 753
Var #PersY1 96
Var #PersC1 7368818
// ================ когда нет союза, крестик на другой высоте.
Var #PersY11 131
// ================ когда перс восстановлен, крестик тоже на другой высоте.
Var #PersY12 219

Var #PersX2 772
Var #PersY2 330
Var #PersC2 3092273

// ====================================== Продолжить/Принять (перед боем). 1025 655 3875117 
Var #NextX1 1025
Var #NextY1 655
Var #NextC1 12801

Var #NextX2 1005
Var #NextY2 655
Var #NextC2 12801

// ====================================== Индикаторы выбора уровня противника.
Var #ElvlX1 731
Var #ElvlY1 116
Var #ElvlC1 3158067

Var #ElvlX2 731
Var #ElvlY2 564
Var #ElvlC2 3092273

// ====================================== Пауза во время боя.
Var #PauseX1 439
Var #PauseY1 549
Var #PauseC1 -65793

Var #PauseX2 711
Var #PauseY2 549
Var #PauseC2 -65793


// ====================================== Следующий бой (Поражение).
            Var #LoseX1 568
Var #LoseY1 329
Var #LoseC1 -3684408

// ====================================== Следующий бой (Победа).
Var #WinX1 566
Var #WinY1 295
Var #WinC1 -3684408

// ====================================== Касание экрана в конце серии.

            //======================================= Победа (касание).точки на флагах  
            //1х1
            Var #PobedaX1 566
Var #PobedaY1 293
Var #PobedaC1 -3684408

Var #PobedaX2 340
Var #PobedaY2 309
Var #PobedaC2 2433051

//3х3
Var #PobedaX11 566
Var #PobedaY11 293
Var #PobedaC11 -3684408

Var #PobedaX21 733
Var #PobedaY21 293
Var #PobedaC21 -3684408

// 3х3 ======================================= Победа (без флагов) 
Var #PobedaX31 722
Var #PobedaY31 653
Var #PobedaC31 18178

Var #PobedaX41 822
Var #PobedaY41 653
Var #PobedaC41 18178

//======================================= Поражение (касание).точки на флагах
//1х1
            Var #PorazgX1 315
Var #PorazgY1 377
Var #PorazgC1 2893860

Var #PorazgX2 555
Var #PorazgY2 342
Var #PorazgC2 -65793

//3х3
Var #PorazgX11 256
Var #PorazgY11 315
Var #PorazgC11 3092273

Var #PorazgX21 566
Var #PorazgY21 329
Var #PorazgC21 -3684408

// ====================================== Вход в режим боя (есть кнопка паузы).
Var #InBattleX1 589
Var #InBattleY1 37
Var #InBattleC1 282374

// ====================================== Индикаторы Ульты.
Var #UltaX1 300
Var #UltaY1 625
Var #UltaC1 2328114
Var #UltaC2 1667746

// ====================================== Индикаторы входа с другого устройства.
// ==================== Вошли с другого устройства.
            Var #DisconnectX1 690
Var #DisconnectY1 371
Var #DisconnectC1 2453030

Var #DisconnectX2 455
Var #DisconnectY2 369
Var #DisconnectC2 3110193

// ==================== Время сеанса истекло.
Var #DisconnectX11 450
Var #DisconnectY11 397
Var #DisconnectC11 1066766

Var #DisconnectX21 696
Var #DisconnectY21 397
Var #DisconnectC21 1068302
// >>%

//===================================================================
//========================= Код программы ===========================
//===================================================================
// Служебные переменные.
// <<~
            Var #Tar 1
Var #Nar 0
Var #Nohelp
Var #Npom 0
Var #Nb 0
Var #N 0
Var #color 0
Var #color2 0
Var #color3 0
Var #Arena 0
Var #Nkont 0
Var #SvpA 0
Var #SvpX1 0
Var #SvpX2 0
Var #HitPause 0
Var #Usl1 0
Var #Usl2 0
Var #SvpSpeed 20
Var #ChargeHAttack 450
Var #Ogidalka 0
 

Var #VboyC1max 0
Var #VboyC2max 0
Var #SvorC1max 0
Var #SvorC2max 0
Var #KonfC1max 0
Var #KonfC2max 0
Var #ScrArenC1max 0
Var #ScrArenC2max 0
Var #ScrPers1C1max 0
Var #ScrPers1C2max 0
Var #ScrPers1C3max 0
Var #ScrPers1C31max 0
Var #ScrPers2C1max 0
Var #ScrPers2C2max 0
Var #ScrPers2C3max 0
Var #ScrPers2C31max 0
Var #ScrPers2C4max 0
Var #ScrPers2C5max 0
Var #ScrPers2C51max 0
Var #PersC1max 0
Var #PersC2max 0
Var #NextC1max 0
Var #NextC2max 0
Var #ElvlC1max 0
Var #ElvlC2max 0
Var #LoseC1max 0
Var #WinC1max 0
Var #PobedaC1max 0
Var #PobedaC2max 0
Var #PorazgC1max 0
Var #PorazgC2max 0
Var #PobedaC11max 0
Var #PobedaC21max 0
Var #PorazgC11max 0
Var #PorazgC21max 0
Var #InBattleC1max 0
Var #UltaC1max 0
Var #UltaC2max 0
Var #DisconnectC1max 0
Var #DisconnectC2max 0
Var #DisconnectC11max 0
Var #DisconnectC21max 0

Var #VboyC1min 0
Var #VboyC2min 0
Var #SvorC1min 0
Var #SvorC2min 0
Var #KonfC1min 0
Var #KonfC2min 0
Var #ScrArenC1min 0
Var #ScrArenC2min 0
Var #ScrPers1C1min 0
Var #ScrPers1C2min 0
Var #ScrPers1C3min 0
Var #ScrPers1C31min 0
Var #ScrPers2C1min 0
Var #ScrPers2C2min 0
Var #ScrPers2C3min 0
Var #ScrPers2C31min 0
Var #ScrPers2C4min 0
Var #ScrPers2C5min 0
Var #ScrPers2C51min 0
Var #PersC1min 0
Var #PersC2min 0
Var #NextC1min 0
Var #NextC2min 0
Var #ElvlC1min 0
Var #ElvlC2min 0
Var #LoseC1min 0
Var #WinC1min 0
Var #PobedaC1min 0
Var #PobedaC2min 0
Var #PorazgC1min 0
Var #PorazgC2min 0
Var #PobedaC11min 0
Var #PobedaC21min 0
Var #PorazgC11min 0
Var #PorazgC21min 0
Var #InBattleC1min 0
Var #UltaC1min 0
Var #UltaC2min 0
Var #DisconnectC1min 0
Var #DisconnectC2min 0
Var #DisconnectC11min 0
Var #DisconnectC21min 0
// >>~


: start

 // Рассчет значений цветов с учетом допустимой погрешности.
# VboyC1max = #VboyC1 + #Difference
# VboyC2max = #VboyC2 + #Difference
# SvorC1max = #SvorC1 + #Difference
# SvorC2max = #SvorC2 + #Difference
# KonfC1max = #KonfC1 + #Difference
# KonfC2max = #KonfC2 + #Difference
# ScrArenC1max = #ScrArenC1 + #Difference
# ScrArenC2max = #ScrArenC2 + #Difference
# ScrPers1C1max = #ScrPers1C1 + #Difference
# ScrPers1C2max = #ScrPers1C2 + #Difference
# ScrPers1C3max = #ScrPers1C3 + #Difference
# ScrPers1C31max = #ScrPers1C31 + #Difference
# ScrPers2C1max = #ScrPers2C1 + #Difference
# ScrPers2C2max = #ScrPers2C2 + #Difference
# ScrPers2C3max = #ScrPers2C3 + #Difference
# ScrPers2C31max = #ScrPers2C31 + #Difference
# ScrPers2C4max = #ScrPers2C4 + #Difference
# ScrPers2C5max = #ScrPers2C5 + #Difference
# ScrPers2C51max = #ScrPers2C51 + #Difference
# PersC1max = #PersC1 + #Difference
# PersC2max = #PersC2 + #Difference
# NextC1max = #NextC1 + #Difference
# NextC2max = #NextC2 + #Difference
# ElvlC1max = #ElvlC1 + #Difference
# ElvlC2max = #ElvlC2 + #Difference
# LoseC1max = #LoseC1 + #Difference
# WinC1max = #WinC1 + #Difference
# PobedaC1max = #PobedaC1 + #Difference
# PobedaC2max = #PobedaC2 + #Difference
# PorazgC1max = #PorazgC1 + #Difference
# PorazgC2max = #PorazgC2 + #Difference
# PobedaC11max = #PobedaC11 + #Difference
# PobedaC21max = #PobedaC21 + #Difference
# PorazgC11max = #PorazgC11 + #Difference
# PorazgC21max = #PorazgC21 + #Difference
# InBattleC1max = #InBattleC1 + #Difference
# UltaC1max = #UltaC1 + #Difference
# UltaC2max = #UltaC2 + #Difference
# DisconnectC1max = #DisconnectC1 + #Difference
# DisconnectC2max = #DisconnectC2 + #Difference
# DisconnectC11max = #DisconnectC11 + #Difference
# DisconnectC21max = #DisconnectC21 + #Difference

# VboyC1min = #VboyC1 - #Difference
# VboyC2min = #VboyC2 - #Difference
# SvorC1min = #SvorC1 - #Difference
# SvorC2min = #SvorC2 - #Difference
# KonfC1min = #KonfC1 - #Difference
# KonfC2min = #KonfC2 - #Difference
# ScrArenC1min = #ScrArenC1 - #Difference
# ScrArenC2min = #ScrArenC2 - #Difference
# ScrPers1C1min = #ScrPers1C1 - #Difference
# ScrPers1C2min = #ScrPers1C2 - #Difference
# ScrPers1C3min = #ScrPers1C3 - #Difference
# ScrPers1C31min = #ScrPers1C31 - #Difference
# ScrPers2C1min = #ScrPers2C1 - #Difference
# ScrPers2C2min = #ScrPers2C2 - #Difference
# ScrPers2C3min = #ScrPers2C3 - #Difference
# ScrPers2C31min = #ScrPers2C31 - #Difference
# ScrPers2C4min = #ScrPers2C4 - #Difference
# ScrPers2C5min = #ScrPers2C5 - #Difference
# ScrPers2C51min = #ScrPers2C51 - #Difference
# PersC1min = #PersC1 - #Difference
# PersC2min = #PersC2 - #Difference
# NextC1min = #NextC1 - #Difference
# NextC2min = #NextC2 - #Difference
# ElvlC1min = #ElvlC1 - #Difference
# ElvlC2min = #ElvlC2 - #Difference
# LoseC1min = #LoseC1 - #Difference
# WinC1min = #WinC1 - #Difference
# PobedaC1min = #PobedaC1 - #Difference
# PobedaC2min = #PobedaC2 - #Difference
# PorazgC1min = #PorazgC1 - #Difference
# PorazgC2min = #PorazgC2 - #Difference
# PobedaC11min = #PobedaC11 - #Difference
# PobedaC21min = #PobedaC21 - #Difference
# PorazgC11min = #PorazgC11 - #Difference
# PorazgC21min = #PorazgC21 - #Difference
# InBattleC1min = #InBattleC1 - #Difference
# UltaC1min = #UltaC1 - #Difference
# UltaC2min = #UltaC2 - #Difference
# DisconnectC1min = #DisconnectC1 - #Difference
# DisconnectC2min = #DisconnectC2 - #Difference
# DisconnectC11min = #DisconnectC11 - #Difference
# DisconnectC21min = #DisconnectC21 - #Difference

 // Установка текущей арены при старте скрипта.
 If #A1 == #Tar
	#Arena = 1
ElseIf #A2 == #Tar
	#Arena = 2
ElseIf #A3 == #Tar
	#Arena = 3
ElseIf #A4 == #Tar
	#Arena = 4
ElseIf #A5 == #Tar
	#Arena = 5
ElseIf #A6 == #Tar
	#Arena = 6
ElseIf #A7 == #Tar
	#Arena = 7
Else
    Toast Нет выбранной арены с приоритетом 1!

    sleep 4000

    goto :End
EndIf

// Холостой клик.
            If #Holclk == 1
	touchPress 0 0 0

    sleep 100   0
EndIf

////////////// НАЧАЛО ГЛАВНОГО ЦИКЛА ///////////////////////////////
/////////////////////////////////////////////////////////////////////////////

: MarcStart

 //============== Костыли ===========================================
 //================================================================

 // Проверка открытия персонажа на экране выбора персонажа (Есть союз). 
 GetColor #color #PersX1 #PersY1
GetColor #color2 #PersX2 #PersY2
IF #color >= #PersC1min And #color <= #PersC1max And #color2 >= #PersC2min And #color2 <= #PersC2max
	keyDown K_BACK

    keyUp K_BACK

    Sleep 2100
EndIF

// нажатие помощи 3на3 1й запрос крестик ниже 
GetColor #color #Pers2X3 #PersY3
IF #color == -919307
	touchdown 0
EndIF

// Проверка открытия персонажа на экране выбора персонажа (Нет союза). 
GetColor #color #PersX1 #PersY11
GetColor #color2 #PersX2 #PersY2
IF #color >= #PersC1min And #color <= #PersC1max And #color2 >= #PersC2min And #color2 <= #PersC2max
	keyDown K_BACK

    keyUp K_BACK

    Sleep 2100
EndIF

// Проверка открытия персонажа на экране выбора персонажа (Перс восстановлен). 
GetColor #color #PersX1 #PersY12
GetColor #color2 #PersX2 #PersY2
IF #color >= #PersC1min And #color <= #PersC1max And #color2 >= #PersC2min And #color2 <= #PersC2max
	keyDown K_BACK

    keyUp K_BACK

    Sleep 2100
EndIF

//================================================================
//================================================================

// Проверка входа с другого устройства (Вошли с другого устройства). 
GetColor #color #DisconnectX1 #DisconnectY1
GetColor #color2 #DisconnectX2 #DisconnectY2
IF #color >= #DisconnectC1min And #color <= #DisconnectC1max And #color2 >= #DisconnectC2min And #color2 <= #DisconnectC2max
	Sleep #DisconnectPause
	keyDown K_BACK
    keyUp K_BACK
    Sleep 8000
EndIF

// Проверка входа с другого устройства (Время сеанса истекло). 
GetColor #color #DisconnectX11 #DisconnectY11
GetColor #color2 #DisconnectX21 #DisconnectY21
IF #color >= #DisconnectC11min And #color <= #DisconnectC11max And #color2 >= #DisconnectC21min And #color2 <= #DisconnectC21max
	Sleep #DisconnectPause
	keyDown K_BACK
    keyUp K_BACK
    Sleep 8000
EndIF

// Условие нажатия клавиши "в бой". 
GetColor #color #VboyX1 #VboyY1
GetColor #color2 #VboyX2 #VboyY2
IF #color >= #VboyC1min and #color <= #VboyC1max and #color2 >= #VboyC2min and #color2 <= #VboyC2max
	goto :Vboy
    : EndVboy
 EndIF

// Условие сворачивания заданий союза.
            GetColor #color #SvorX1 #SvorY1
GetColor #color2 #SvorX2 #SvorY2
IF #color >= #SvorC1min and #color <= #SvorC1max and #color2 >= #SvorC2min and #color2 <= #SvorC2max
	goto :Conflict0
    : EndConflict0
 EndIF

// Условие входа в режим "Конфликт".
            GetColor #color #KonfX1 #KonfY1
GetColor #color2 #KonfX2 #KonfY2
IF #color >= #KonfC1min and #color <= #KonfC1max and #color2 >= #KonfC2min and #color2 <= #KonfC2max
	goto :Conflict
    : EndConflict
 EndIF

// Условие входа в арену.
            GetColor #color #ScrArenX1 #ScrArenY1
GetColor #color2 #ScrArenX2 #ScrArenY2
IF #color >= #ScrArenC1min And #color <= #ScrArenC1max And #color2 >= #ScrArenC2min And #color2 <= #ScrArenC2max
    	Set #N 0    		
	goto :InArena
EndIF

//=====================================
// 1 Арена
// Условия просьбы помощи на персонажах и выбора персонажей для боя на арене 1х1.
            If #Arena == 1
	GetColor #color #ScrPers1X1 #ScrPers1Y1
	GetColor #color2 #ScrPers1X2 #ScrPers1Y2
	IF #color >= #ScrPers1C1min And #color <= #ScrPers1C1max And #color2 >= #ScrPers1C2min And #color2 <= #ScrPers1C2max
    		GetColor #color #ScrPers1X3 #ScrPers1Y3
    		IF #color < #ScrPers1C3min or #color > #ScrPers1C3max
        			Set #N 0
     			goto :ViborA1
            ElseIF #color >= #ScrPers1C3min and #color <= #ScrPers1C3max
        			Set #N 0        			
			goto :PrositA1
            EndIf

     EndIF
 EndIF

//======================================
//Арена 2
// Условия просьбы помощи на персонажах и выбора персонажей для боя на аренах 3х3.
            If #Arena >= 2
	GetColor #color #ScrPers2X1 #ScrPers2Y1
	IF #color < #ScrPers2C1min or #color > #ScrPers2C1max
		GetColor #color2 #ScrPers2X2 #ScrPers2Y2
		IF #color2 >= #ScrPers2C2min And #color2 <= #ScrPers2C2max 
			GetColor #color3 #ScrPers2X4 #ScrPers2Y4
			If #color3 < #ScrPers2C4min or #color3 > #ScrPers2C4max 
    				GetColor #color #ScrPers2X3 #ScrPers2Y3
    				IF #color < #ScrPers2C3min or #color > #ScrPers2C3max
         					Set #N 0
       					goto :ViborA2
                    ElseIF #color >= #ScrPers2C3min And #color <= #ScrPers2C3max
        					Set #N 0
        					goto :PrositA2
                    EndIf

            EndIF
         EndIF

     EndIF
EndIF

// Условия просьбы помощи на персонажах и выбора персонажей для боя на аренах 3х3 (При низком количестве персонажей).
            If #Arena >= 2
	GetColor #color #ScrPers2X1 #ScrPers2Y1
	IF #color < #ScrPers2C1min or #color > #ScrPers2C1max
		GetColor #color2 #ScrPers2X2 #ScrPers2Y2
		GetColor #color3 #ScrPers2X4 #ScrPers2Y4
		IF #color2 >= #ScrPers2C2min And #color2 <= #ScrPers2C2max And #color3 >= #ScrPers2C4min And #color3 <= #ScrPers2C4max
    			GetColor #color #ScrPers2X5 #ScrPers2Y5 
    			IF #color < #ScrPers2C5min or #color > #ScrPers2C5max
         				Set #N 0
       				goto :ViborA3
                ElseIF #color >= #ScrPers2C5min And #color <= #ScrPers2C5max
        				Set #N 0
        				goto :PrositA3
                EndIf

         EndIF
     EndIF
EndIF

// Условие нажатия клавиш "Продолжить" и "Принять" перед боем на аренах 3х3.
If #Arena >= 2
	GetColor #color #NextX1 #NextY1
	GetColor #color2 #NextX2 #NextY2
EndIF
IF #Arena >= 2 And #color >= #NextC1min And #color <= #NextC1max
	#Usl1 = 1
Else
# Usl1 = 0
EndIf
IF #Arena >= 2 And #color2 >= #NextC2min And #color2 <= #NextC2max
	#Usl2 = 1
Else
	#Usl2 = 0
EndIf
If #Arena >= 2
	IF #Usl1 == 1 or #Usl2 == 1
		goto :EnemyLvl
        : EndEnemyLvl
                 Set #N 0
        		goto :ProdolA2
    Endif
EndIF

// Условие нажатия клавиш "Следующий бой" и "Последний бой" при поражении.
If #Arena >= 2
	GetColor #color #LoseX1 #LoseY1
	IF #color >= #LoseC1min And #color <= #LoseC1max
        		Set #N 0
        		goto :Prodol2A2
    Endif
EndIF

// Условие нажатия клавиш "Следующий бой" и "Последний бой" при победе.
If #Arena >= 2
	GetColor #color #WinX1 #WinY1
	IF #color >= #WinC1min And #color <= #WinC1max
        		Set #N 0
        		goto :Prodol3A2
    Endif
EndIF

//Касание в конце боя (победа). 1х1
GetColor #color #PobedaX1 #PobedaY1
GetColor #color2 #PobedaX2 #PobedaY2 
If #color >= #PobedaC1min And #color <= #PobedaC1max And #color2 >= #PobedaC2min And #color2 <= #PobedaC2max
	TouchPress 0 582 525

    Sleep 2500
EndIf

//Касание в конце боя (поражение). 1х1
GetColor #color #PorazgX1 #PorazgY1
GetColor #color2 #PorazgX2 #PorazgY2
If #color >= #PorazgC1min And #color <= #PorazgC1max And #color2 >= #PorazgC2min And #color2 <= #PorazgC2max
	TouchPress 0 582 525

    Sleep 2500
EndIf

//Касание в конце серии (победа). 3х3
GetColor #color #PobedaX11 #PobedaY11
GetColor #color2 #PobedaX21 #PobedaY21 
If #color >= #PobedaC11min And #color <= #PobedaC11max And #color2 >= #PobedaC21min And #color2 <= #PobedaC21max
	TouchPress 0 1020 620

    Sleep 4000
EndIf

//Касание в конце серии (победа). 3х3 (без флагов)
GetColor #color #PobedaX31 #PobedaY31
GetColor #color2 #PobedaX41 #PobedaY41 
If #color == #PobedaC31  And #color2 == #PobedaC41
 TouchPress 0 1020 620

     Sleep 4000
log Pobega
EndIf

//Касание в конце серии (поражение).
GetColor #color #PorazgX11 #PorazgY11
GetColor #color2 #PorazgX21 #PorazgY21
If #color >= #PorazgC11min And #color <= #PorazgC11max And #color2 >= #PorazgC21min And #color2 <= #PorazgC21max
	TouchPress 0 1020 620

    Sleep 4000
EndIf

// Вход в бой.
GetColor #color #InBattleX1 #InBattleY1
IF #color >= #InBattleC1min And #color <= #InBattleC1max
	goto :Sht
    : EndSht
	#N = 0
	#Ogidalka = 0
	goto :PointerBitva
EndIF

//Выход из паузы во время боя
            GetColor #color #PauseX1 #PauseY1
GetColor #color2 #PauseX2 #PauseY2 
If #color == #PauseC1  And #color2 == #PauseC2
 TouchPress 0 850 600

     Sleep 4000
EndIf

// Базовый счетчик и аварийный сброс.
: MarcEnd
 IF #N > #CtrlN And #CheckStartApp == 1	 
	RunApp com.kabam.marvelbattle
    Sleep 4000
EndIF
IF #N > #CtrlN    
	keyDown K_BACK

    keyUp K_BACK

    Sleep 50

    keyDown K_BACK

    keyUp K_BACK

    Sleep 50

    keyDown K_BACK

    keyUp K_BACK

    Set #N 0
EndIF
#N = #N + 1
sleep #Pause
goto :MarcStart

////////////// КОНЕЦ ГЛАВНОГО ЦИКЛА /////////////////////////////////
/////////////////////////////////////////////////////////////////////////////


//================= Процедуры ================================================================
//==========================================================================================

// Выбор команды противника.
: EnemyLvl
     If  #EnemyLvl != 1 And  #EnemyLvl != 2 And  #EnemyLvl != 3
		goto :EndEnemyLvl
    EndIf


     GetColor #color #ElvlX1 #ElvlY1
	GetColor #color2 #ElvlX2 #ElvlY2
	If  #color >= #ElvlC1min And #color <= #ElvlC1max And #color2 >= #ElvlC2min And #color2 <= #ElvlC2max And #EnemyLvl == 1
		touchPress 0 695 189

        sleep 2100

    ElseIf #color >= #ElvlC1min And #color <= #ElvlC1max And #color2 >= #ElvlC2min And #color2 <= #ElvlC2max And #EnemyLvl == 2
		touchPress 0 695 350

        sleep 2100

    ElseIf #color >= #ElvlC1min And #color <= #ElvlC1max And #color2 >= #ElvlC2min And #color2 <= #ElvlC2max
		touchPress 0 695 509

        sleep 2100

    EndIf
goto :EndEnemyLvl

// Счетчики отыгранных боев (для запуска помощи союзникам и смены арен).
: Sht
     If #Pomogat == 1
		#Npom = #Npom + 1	
	EndIf

    # Nar = #Nar + 1

            goto :EndSht

// нажатие клавиши "в бой".
: Vboy
     touchPress 0 312 122

    sleep 2100
goto :EndVboy

/// Свертывание заданий союза.
: Conflict0
     touchdown 0 600 146
      sleep 10
      touchup 0


    sleep 4100

     touchdown 0 600 146
      sleep 10
      touchup 0


    sleep 4100

goto :EndConflict0

/// Вход в режим "Конфликт".
: Conflict
     touchdown 0 615 416
      sleep 10
      touchup 0

    sleep 4100
goto :EndConflict
// Вход в арену, выбор алгоритма входа.
: InArena

     If #Arena == 1
		goto :A1
    ElseIf #Arena == 2
		goto :A2
    ElseIf #Arena == 3
		goto :A3
    ElseIf #Arena == 4
		goto :A4
    ElseIf #Arena == 5
		goto :A5
    ElseIf #Arena == 6
		goto :A6
    ElseIf #Arena == 7
		goto :A7
    EndIf

goto :MarcEnd

// Вход в первую арену.
: A1
     touchPress 0 150 382

    sleep 4000
goto :MarcEnd

// Вход во вторую арену.
: A2
     touchPress 0 428 379

    sleep 4000
goto :MarcEnd

// Вход в третью арену.
: A3
     touchPress 0 952 379

    sleep 4000
goto :MarcEnd

// Вход в четвертую арену.
: A4
	#SvpA = 1
	goto :ArenaProK
/////////////////////////////

// Вход в пятую арену.
: A5
	#SvpA = 2
	goto :ArenaProK
/////////////////////////////

// Вход в шестую арену.
: A6
	#SvpA = 3
	goto :ArenaProK
/////////////////////////////

// Вход в седьмую арену.
: A7
	#SvpA = 4
	goto :ArenaProK
/////////////////////////////

// Сдвиг страницы арен.
: ArenaProK

    if #SvpA <= 0
		{
                goto :}

            Marc1End
    EndIf

    # Nb = 1135
            touchDown 0 1135 368

    sleep 1000
	
	:Marc1

    touchMove 0 #Nb 368
	sleep 6


    if #Nb > 600
		#Nb = #Nb - 2
		{
                goto :}

            Marc1
    endIf


    sleep 1000

    touchUp 0

    sleep 1000

    # SvpA = #SvpA - 1
            goto :ArenaProK

    : Marc1End
     sleep 2000
goto :A3

// Выбор бойцов арены 1х1 или старт алгоритма помощи союзникам или смена арены.
: ViborA1
     If #Pomogat == 1 and #Npom >= #CtrlNpom
		goto :Pomosh
    EndIf


    IF #color >= #ScrPers1C31min and #color <= #ScrPers1C31max
		goto :ProverkaEsheRaz1
    ElseIf #Arena == 1 And #Nar >= #An1
		goto :SmenaAreny
    ElseIf #Arena == 2 And #Nar >= #An2
		goto :SmenaAreny
    ElseIf #Arena == 3 And #Nar >= #An3
		goto :SmenaAreny
    ElseIf #Arena == 4 And #Nar >= #An4 
		goto :SmenaAreny
    ElseIf #Arena == 5 And #Nar >= #An5
		goto :SmenaAreny
    ElseIf #Arena == 6 And #Nar >= #An6
		goto :SmenaAreny
    ElseIf #Arena == 7 And #Nar >= #An7
		goto :SmenaAreny
    EndIf


    If #Ogidalka == 0
		#Ogidalka = 1
		Sleep 2100

        goto :MarcEnd
    EndIf


    touchDown 0 380 256

    sleep 100

    touchMove 0 173 118

    sleep 100

    touchUp 0

    sleep 100


    touchPress 0 120 621

    sleep 2000

goto :MarcEnd

// Удостовериться, что персонажи закончились (защита от сбоя).
: ProverkaEsheRaz1
     sleep 4000

    GetColor #color #ScrPers1X3 #ScrPers1Y3
	IF #color >= #ScrPers1C31min and #color <= #ScrPers1C31max
		#Nkont = 2
		goto :SmenaAreny
    EndIf
goto :MarcEnd

// Просьба помощи для отыгравших бойцов арены 1х1.
: PrositA1
     touchPress 0 293 170
	#Ogidalka = 0
	sleep 1000
goto :MarcEnd

// Выбор бойцов арен 3х3 или старт алгоритма помощи союзникам или смена арены.
: ViborA2
     If #Pomogat == 1 and #Npom >= #CtrlNpom
		goto :Pomosh
    EndIf
// нажатие помощи 3на3 1й запрос крестик ниже 
     GetColor #color 319 260
     IF #color == -656647
	touchdown 0 319 260

    sleep 10
     touchup 0
sleep 500
EndIF

    IF #color >= #ScrPers2C31min And #color <= #ScrPers2C31max
		goto :ProverkaEsheRaz2
    ElseIf #Arena == 1 And #Nar >= #An1
		goto :SmenaAreny
    ElseIf #Arena == 2 And #Nar >= #An2
		goto :SmenaAreny
    ElseIf #Arena == 3 And #Nar >= #An3
		goto :SmenaAreny
    ElseIf #Arena == 4 And #Nar >= #An4 
		goto :SmenaAreny
    ElseIf #Arena == 5 And #Nar >= #An5
		goto :SmenaAreny
    ElseIf #Arena == 6 And #Nar >= #An6
		goto :SmenaAreny
    ElseIf #Arena == 7 And #Nar >= #An7
		goto :SmenaAreny
    EndIf


    If #Ogidalka == 0
		#Ogidalka = 1
		Sleep 2100

        goto :MarcEnd
    EndIf


    touchDown 0 380 338

    sleep 100

    touchMove 0 171 315

    sleep 100

    touchUp 0

    sleep 100


    touchPress 0 120 621

goto :MarcEnd

// Удостовериться, что персонажи закончились (защита от сбоя).
: ProverkaEsheRaz2
     sleep 4000

    GetColor #color #ScrPers2X3 #ScrPers2Y3
	IF #color >= #ScrPers2C31min And #color <= #ScrPers2C31max
		#Nkont = 2
		goto :SmenaAreny
    EndIf
goto :MarcEnd

// Просьба помощи для отыгравших бойцов арен 3х3.
: PrositA2
 If #Nohelp == 1
goto :PrositA5
ElseIf #Nohelp == 0	
	touchdown 0 293 248
      sleep 10
      touchup 0

    # Ogidalka = 0
            sleep 2200
goto :MarcEnd

// фильтр  без помощи
: PrositA5
     touchdown 0 1120 570
      sleep 10
      touchup 0

    # Ogidalka = 0
            sleep 2200
goto :MarcEnd


// Выбор бойцов арен 3х3 или старт алгоритма помощи союзникам или смена арены. (При низком количестве персонажей).
: ViborA3
     If #Pomogat == 1 and #Npom >= #CtrlNpom
		goto :Pomosh
    EndIf


    IF #color >= #ScrPers2C51min And #color <= #ScrPers2C51max
		goto :ProverkaEsheRaz3
    ElseIf #Arena == 1 And #Nar >= #An1
		goto :SmenaAreny
    ElseIf #Arena == 2 And #Nar >= #An2
		goto :SmenaAreny
    ElseIf #Arena == 3 And #Nar >= #An3
		goto :SmenaAreny
    ElseIf #Arena == 4 And #Nar >= #An4 
		goto :SmenaAreny
    ElseIf #Arena == 5 And #Nar >= #An5
		goto :SmenaAreny
    ElseIf #Arena == 6 And #Nar >= #An6
		goto :SmenaAreny
    ElseIf #Arena == 7 And #Nar >= #An7
		goto :SmenaAreny
    EndIf


    If #Ogidalka == 0
		#Ogidalka = 1
		Sleep 2100

        goto :MarcEnd
    EndIf


    touchDown 0 586 338

    sleep 100

    touchMove 0 171 315

    sleep 100

    touchUp 0

    sleep 100


    touchPress 0 120 621

goto :MarcEnd

// Удостовериться, что персонажи закончились (защита от сбоя) (При низком количестве персонажей).
: ProverkaEsheRaz3
     sleep 4000

    GetColor #color #ScrPers2X5 #ScrPers2Y5
	IF #color >= #ScrPers2C51min And #color <= #ScrPers2C51max
		#Nkont = 2
		goto :SmenaAreny
    EndIf
goto :MarcEnd

// Просьба помощи для отыгравших бойцов арен 3х3 (При низком количестве персонажей).
: PrositA3
     touchPress 0 500 248
	#Ogidalka = 0
	sleep 2500
goto :MarcEnd

// Нажатие клавиш "Продолжить" и "Принять" перед боем на аренах 3х3.
: ProdolA2
     touchPress 0 1050 635

    sleep 200
goto :MarcEnd

// Нажатие клавиш "Следующий бой" и "Последний бой" при поражении.
: Prodol2A2
     touchPress 0 715 420

    sleep 200
goto :MarcEnd

// Нажатие клавиш "Следующий бой" и "Последний бой" при победе.
: Prodol3A2
     touchPress 0 715 530

    sleep 200
goto :MarcEnd

// Алгоритм помощи союзникам.
: Pomosh
# Npom = 0

     touchPress 0 215 35

    sleep 6000


    touchPress 0 437 124

    sleep 16000


    touchPress 0 575 177

    sleep 6000
	
	#Nb = 0
	
	:MarcPomosh

    touchPress 0 923 245

    sleep 1000



    If #Nb < #CtrlNpomEnd
		#Nb = #Nb + 1
		goto :MarcPomosh
    Endif


    sleep 2000


    touchPress 0  215 35

    sleep 6000

goto :Vboy

// Смена текущей арены.
: SmenaAreny
	#Nkont = #Nkont + 1
	if #Nkont < 2
		sleep {
                4000
}

            goto :MarcEnd
    EndIf
	
	#Nkont = 0
	#Nar = 0
	#Nb = #Tar

	:MarcSm

# Tar = #Tar + 1

    If #A1 == #Tar
		#Arena = 1
	ElseIf #A2 == #Tar
		#Arena = 2
	ElseIf #A3 == #Tar
		#Arena = 3
	ElseIf #A4 == #Tar
		#Arena = 4
	ElseIf #A5 == #Tar
		#Arena = 5
	ElseIf #A6 == #Tar
		#Arena = 6
	ElseIf #A7 == #Tar
		#Arena = 7
	Else
		#Tar = 0
		goto :MarcSm
    EndIf


    If #Nb == #Tar
		goto :MarcEnd
    EndIf


    If #Tar == 1
		Sleep #PauseOverArena
	EndIf

    keyDown K_BACK
    keyUp K_BACK

goto :MarcEnd

//Маршрутизатор боевок (Вход в режим боя).
: PointerBitva
     If #Boevka == 1
		goto :Bitva1
    ElseIf #Boevka == 2 
		goto :Bitva2
    ElseIf #Boevka == 3 
		goto :Bitva3
    ElseIf #Boevka == 4 
		goto :Bitva4
    ElseIf #Boevka == 5 
		goto :Bitva5
    ElseIf #Boevka == 6 
		goto :Bitva6
    ElseIf #Boevka == 7
		goto :Bitva7
    ElseIf #Boevka == 8
		goto :Bitva8
    ElseIf #Boevka == 9
		goto :Bitva9
    ElseIf #Boevka == 10
		goto :Bitva10
    EndIf
goto :Bitva1

//Маршрутизатор боевок (возврат в заданную боевку).
: PointerBoevka
     If #Boevka == 1
		goto :MarcBitva1
    ElseIf #Boevka == 2 
		goto :MarcBitva2
    ElseIf #Boevka == 3 
		goto :MarcBitva3
    ElseIf #Boevka == 4 
		goto :MarcBitva4
    ElseIf #Boevka == 5 
		goto :MarcBitva5
    ElseIf #Boevka == 6 
		goto :MarcBitva6
    ElseIf #Boevka == 7
		goto :MarcBitva7
    ElseIf #Boevka == 8
		goto :MarcBitva8
    ElseIf #Boevka == 9
		goto :MarcBitva9
    ElseIf #Boevka == 10
		goto :MarcBitva10
    EndIf
goto :Bitva1

//======== Боевые приемы =====================
// Свайп влево.
: SwipeLeft
# SvpX1 = 560 
# SvpX2 = 150
    touchDown 0 #SvpX1 350
	:MarcSVP1
    touchMove 0 #SvpX1 350
	sleep 2

    if #SvpX1 > #SvpX2
		#SvpX1 = #SvpX1 - #SvpSpeed
		{
                goto :}

            MarcSVP1
    endIf

    touchUp 0
	#Nb = #Nb + 1
	Sleep #HitPause
goto :PointerBoevka

// Свайп вправо.
: SwipeRight
# SvpX1 = 150 
# SvpX2 = 560
    touchDown 0 #SvpX1 350
	:MarcSVP2
    touchMove 0 #SvpX1 350
	sleep 2

    if #SvpX1 < #SvpX2
		#SvpX1 = #SvpX1 + #SvpSpeed
		{
                goto :}

            MarcSVP2
    endIf

    touchUp 0
	#Nb = #Nb + 1
	Sleep #HitPause
goto :PointerBoevka

// Блок.
: Block
     touchDown 0 150 350

    Sleep 1500

    touchUp 0
	#Nb = #Nb + 1
goto :PointerBoevka

// Тяжелая атака.
: HAttack
     touchDown 0 1000 350

    Sleep #ChargeHAttack
	touchUp 0
	#Nb = #Nb + 1
	Sleep #HitPause
goto :PointerBoevka

// Легкая атака.
: LAttack
     touchPress 0 1000 350
	#Nb = #Nb + 1
	Sleep #HitPause
goto :PointerBoevka

//Применение ульты.
: Ulta
     If #Ulta == 0
		goto :EndUlta
    ElseIf #Ulta == 1	
		touchPress 0 169 603

        goto :EndUlta
    EndIf


    GetColor #color #UltaX1 #UltaY1
	If #Ulta == 2 And #color >= #UltaC1min And #color <= #UltaC1max 	
		touchPress 0 169 603

        goto :EndUlta
    ElseIf #Ulta == 2 And #color >= #UltaC2min And #color <= #UltaC2max 	
		touchPress 0 169 603

        goto :EndUlta
    ElseIf #Ulta == 3 And #color >= #UltaC2min And #color <= #UltaC2max 	
		touchPress 0 169 603

        goto :EndUlta
    Endif
	
	:EndUlta
# Nb = #Nb + 1
    Sleep #HitPause
goto :PointerBoevka

//=============== БОЕВЫЕ РОТАЦИИ ================
//==============================================
//========= Пояснения по синтаксису: ===============
//	
//	Ротацию прописывать внутри таких областей (остальное не трогать):
//		////////////////////// Последовательнось действий //////////////////////////////
//                       			< Тут должна быть ротация >    
//		///////////////////////////////////////////////////////////////////////////////////////
//
//	#HitPause = n - параметр, задающий в мс паузу, которая будет выдержана ПОСЛЕ указанного действия
//	(для блока этот параметр задает время удержания блока). 
//		Например, следующая запись означает, что будет сделан свайп влево, затем сработает пауза в 600 мс.
//			#HitPause = 600		
//			goto :SwipeLeft
//	#SvpSpeed = n - устанавливает скорость выполнения свайпов.
//	#ChargeHAttack = n  - устанавливает время зарядки тяжелого удара.
//
//	#Nb - счетчик последовательности (при каждом действии автоматически повышается).
//
//	Доступные действия:
//		goto :SwipeLeft - свайп влево.
//		goto :SwipeRight - свайп вправо.
//		goto :Block - блок.
//		goto :HAttack - тяжелая атака.
//		goto :LAttack - легкая атака.
//		goto :Ulta - ульта.
//
//=============================================

//=============================================
//Боевая ротация (1).
: Bitva1
# Nb = 0
    : MarcBitva1

     ////////////////////// Последовательнось действий //////////////////////////////

     If #Nb >= 0 And #Nb <= 50
		#HitPause = 0
		goto :LAttack

    ElseIf #Nb == 51
		#HitPause = 0
		goto :Ulta

    Endif

    ///////////////////////////////////////////////////////////////////////////////////////

            // Условие выхода из боя.
            GetColor #color #InBattleX1 #InBattleY1
	IF #color < #InBattleC1min or #color > #InBattleC1max
		Sleep 2000

        goto :MarcEnd
    Endif
goto :Bitva1

//=============================================
//Боевая ротация (2). боёвка от Foxy
: Bitva2
# Nb = 0
    : MarcBitva2

     ////////////////////// Последовательнось действий //////////////////////////////

     If #Nb == 0 or #Nb == 1
		#HitPause = 600		
		goto :SwipeLeft

    ElseIf #Nb == 2
		#HitPause = 800
		goto :Block

    Elseif #Nb == 3
		#HitPause = 600
		goto :SwipeRight

    ElseIf #Nb == 4 or #Nb == 5 or #Nb == 6 or #Nb == 7 or #Nb == 8 or #Nb == 9 or #Nb == 10 or #Nb == 11 or #Nb == 12
		#HitPause = 300 
		goto :LAttack

    ElseIf #Nb == 13
		#HitPause = 0
		goto :Ulta

    Endif

    ///////////////////////////////////////////////////////////////////////////////////////

            // Условие выхода из боя.
            GetColor #color #InBattleX1 #InBattleY1
	IF #color < #InBattleC1min or #color > #InBattleC1max
		Sleep 2000

        goto :MarcEnd
    Endif
goto :Bitva2

//==============================================
//Боевая ротация (3).ivawka2649v3
: Bitva3
# Nb = 0
    : MarcBitva3

     ////////////////////// Последовательнось действий //////////////////////////////

     If #Nb >= 0 And #Nb <= 1
		#HitPause = 100		
		goto :SwipeLeft

    Elseif #Nb >= 2 And #Nb <= 3
		#HitPause = 100
		goto :SwipeRight

    ElseIf #Nb >= 4 And #Nb <= 13
		#HitPause =100 
		goto :LAttack

    ElseIf #Nb == 14
		#HitPause = 0
		goto :Ulta

    Endif

    ///////////////////////////////////////////////////////////////////////////////////////

            // Условие выхода из боя.
            GetColor #color #InBattleX1 #InBattleY1
	IF #color < #InBattleC1min or #color > #InBattleC1max
		Sleep 2000

        goto :MarcEnd
    Endif
goto :Bitva3
//==============================================
//Боевая ротация (4).ivawka2649v4
: Bitva4
# Nb = 0
    : MarcBitva4

     ////////////////////// Последовательнось действий //////////////////////////////

     If #Nb == 0
  #HitPause = 30  
  goto :SwipeLeft

 Elseif #Nb == 1
  #HitPause = 30  
  goto :SwipeLeft

 Elseif #Nb == 2
  #HitPause = 30  
  goto :SwipeRight

 Elseif #Nb == 3
  #HitPause = 30
  goto :SwipeRight

 Elseif #Nb == 4
  #HitPause = 30
  goto :SwipeRight

 Elseif #Nb == 5
  #HitPause = 120
  goto :LAttack

 ElseIf #Nb == 6
  #HitPause =120
  goto :LAttack

 ElseIf #Nb == 7
  #HitPause = 120 
  goto :LAttack

 ElseIf #Nb == 8
  #HitPause = 120 
  goto :LAttack

 ElseIf #Nb == 9
  #HitPause = 120
  goto :LAttack

 ElseIf #Nb == 10
  #HitPause = 120
  goto :LAttack

 ElseIf #Nb == 11
  #HitPause = 120
  goto :LAttack

 ElseIf #Nb == 12
  #HitPause =120 
  goto :LAttack

 ElseIf #Nb == 13
  #HitPause = 120
  goto :LAttack

  ElseIf #Nb == 14
  #HitPause = 10
  goto :Ulta

 Endif

    ///////////////////////////////////////////////////////////////////////////////////////

            // Условие выхода из боя.
            GetColor #color #InBattleX1 #InBattleY1
	IF #color < #InBattleC1min or #color > #InBattleC1max
		Sleep 2000

        goto :MarcEnd
    Endif
goto :Bitva4

//==============================================
//Боевая ротация (5). ivawka2649v5 В скрипте Пала.
: Bitva5
# Nb = 0
    : MarcBitva5

 ////////////////////// Последовательнось действий //////////////////////////////


 If #Nb == 0
  #HitPause = 100  
  goto :SwipeLeft

 Elseif #Nb == 1
  #HitPause = 100  
  goto :SwipeLeft



 Elseif #Nb == 2
  #HitPause = 100  
  goto :SwipeRight

 Elseif #Nb == 3
  #HitPause = 100
  goto :SwipeRight

 Elseif #Nb == 4
  #HitPause = 100
  goto :SwipeRight



 Elseif #Nb == 5
  #HitPause = 180
  goto :LAttack

 ElseIf #Nb == 6
  #HitPause =180
  goto :LAttack

 ElseIf #Nb == 7
  #HitPause = 180
  goto :LAttack


 ElseIf #Nb == 8
  #HitPause = 180
  goto :LAttack

 ElseIf #Nb == 9
  #HitPause = 180
  goto :LAttack

 ElseIf #Nb == 10
  #HitPause = 180
  goto :LAttack


 ElseIf #Nb == 11
  #HitPause = 180
  goto :LAttack

 ElseIf #Nb == 12
  #HitPause =180
  goto :LAttack

 ElseIf #Nb == 13
  #HitPause = 180
  goto :LAttack


ElseIf #Nb == 14
  #HitPause =180
  goto :LAttack

ElseIf #Nb == 15
  #HitPause =180
  goto :LAttack

ElseIf #Nb == 16
  #HitPause =180
  goto :LAttack


  ElseIf #Nb == 17
  #HitPause = 10
  goto :Ulta

 Endif

    ///////////////////////////////////////////////////////////////////////////////////////

            // Условие выхода из боя.
            GetColor #color #InBattleX1 #InBattleY1
	IF #color < #InBattleC1min or #color > #InBattleC1max
		Sleep 2000

        goto :MarcEnd
    Endif
goto :Bitva5

//==============================================
//Боевая ротация (6). ivawka2649v5bl
: Bitva6
# Nb = 0
    : MarcBitva6

     ////////////////////// Последовательнось действий //////////////////////////////

     If #Nb == 0
  #HitPause = 100  
  goto :SwipeLeft

 Elseif #Nb == 1
  #HitPause = 100  
  goto :Block



 Elseif #Nb == 2
  #HitPause = 100  
  goto :SwipeRight

 Elseif #Nb == 3
  #HitPause = 100
  goto :SwipeRight

 Elseif #Nb == 4
  #HitPause = 100
  goto :SwipeRight



 Elseif #Nb == 5
  #HitPause = 180
  goto :LAttack

 ElseIf #Nb == 6
  #HitPause =180
  goto :LAttack

 ElseIf #Nb == 7
  #HitPause = 180
  goto :LAttack


 ElseIf #Nb == 8
  #HitPause = 180
  goto :LAttack

 ElseIf #Nb == 9
  #HitPause = 180
  goto :LAttack

 ElseIf #Nb == 10
  #HitPause = 180
  goto :LAttack


 ElseIf #Nb == 11
  #HitPause = 180
  goto :LAttack

 ElseIf #Nb == 12
  #HitPause =180
  goto :LAttack

 ElseIf #Nb == 13
  #HitPause = 180
  goto :LAttack



ElseIf #Nb == 14
  #HitPause =180
  goto :LAttack

ElseIf #Nb == 15
  #HitPause =180
  goto :LAttack

ElseIf #Nb == 16
  #HitPause =180
  goto :LAttack


  ElseIf #Nb == 17
  #HitPause = 10
  goto :Ulta

 Endif

    ///////////////////////////////////////////////////////////////////////////////////////

            // Условие выхода из боя.
            GetColor #color #InBattleX1 #InBattleY1
	IF #color < #InBattleC1min or #color > #InBattleC1max
		Sleep 2000

        goto :MarcEnd
    Endif
goto :Bitva6

//==============================================
//Боевая ротация (7).
: Bitva7
# Nb = 0
    : MarcBitva7

     ////////////////////// Последовательнось действий //////////////////////////////

     If #Nb == 0
  #HitPause = 30  
  goto :SwipeLeft

 Elseif #Nb == 1
  #HitPause = 30  
  goto :SwipeLeft

 Elseif #Nb == 2
  #HitPause = 30  
  goto :SwipeRight

 Elseif #Nb == 3
  #HitPause = 30
  goto :SwipeRight

 Elseif #Nb == 4
  #HitPause = 30
  goto :SwipeRight

 Elseif #Nb == 5
  #HitPause = 120
  goto :LAttack

 ElseIf #Nb == 6
  #HitPause =120
  goto :LAttack

 ElseIf #Nb == 7
  #HitPause = 120 
  goto :LAttack

 ElseIf #Nb == 8
  #HitPause = 120 
  goto :LAttack

 ElseIf #Nb == 9
  #HitPause = 120
  goto :LAttack

 ElseIf #Nb == 10
  #HitPause = 120
  goto :LAttack

 ElseIf #Nb == 11
  #HitPause = 120
  goto :LAttack

 ElseIf #Nb == 12
  #HitPause =120 
  goto :LAttack

ElseIf #Nb == 13
  #HitPause = 120
  goto :LAttack

 ElseIf #Nb == 14
  #HitPause = 120
  goto :LAttack

 ElseIf #Nb == 15
  #HitPause =120 
  goto :LAttack

ElseIf #Nb == 16
  #HitPause = 120
  goto :LAttack

 ElseIf #Nb == 17
  #HitPause =10 
  goto :LAttack

ElseIf #Nb == 18
  #HitPause = 10
  goto :Ulta

 ElseIf #Nb == 19
  #HitPause = 0
  goto :Block



 Endif


    ///////////////////////////////////////////////////////////////////////////////////////

            // Условие выхода из боя.
            GetColor #color #InBattleX1 #InBattleY1
	IF #color < #InBattleC1min or #color > #InBattleC1max
		Sleep 2000

        goto :MarcEnd
    Endif
goto :Bitva7

//==============================================
//Боевая ротация (8).
: Bitva8
# Nb = 0
    : MarcBitva8

     ////////////////////// Последовательнось действий //////////////////////////////

     If #Nb == 0 or #Nb == 1 or #Nb == 3 or #Nb == 4 or #Nb == 6
		#HitPause = 70		
		goto :SwipeLeft

    ElseIf #Nb == 2
		#HitPause = 1250
		goto :Block

    ElseIf #Nb == 5 or #Nb == 7
		#HitPause = 100
		goto :Block

    Elseif #Nb == 8 or #Nb == 9
		#HitPause = 100
		goto :SwipeRight

    ElseIf #Nb >= 10 And #Nb <= 22
		#HitPause = 150 
		goto :LAttack

    ElseIf #Nb == 23
		#HitPause = 120
		goto :LAttack

    ElseIf #Nb == 24
		#HitPause = 850
		#ChargeHAttack = 850 		
		goto :HAttack

    ElseIf #Nb == 25
		#HitPause = 80
		goto :Ulta

    Endif

    ///////////////////////////////////////////////////////////////////////////////////////

            // Условие выхода из боя.
            GetColor #color #InBattleX1 #InBattleY1
	IF #color < #InBattleC1min or #color > #InBattleC1max
		Sleep 2000

        goto :MarcEnd
    Endif
goto :Bitva8

//==============================================
//Боевая ротация (9).
: Bitva9
# Nb = 0
    : MarcBitva9

     ////////////////////// Последовательнось действий //////////////////////////////

     If #Nb == 0 or #Nb == 2 or #Nb == 4 or #Nb == 6 or #Nb == 8 or #Nb == 10 or #Nb == 12 or #Nb == 14 or #Nb == 16
		#HitPause = 0
		goto :Ulta
    ElseIf #Nb == 18 or #Nb == 20 or #Nb == 22 or #Nb == 24 or #Nb == 26 or #Nb == 28 or #Nb == 30 or #Nb == 32 or #Nb == 34
		#HitPause = 0
		goto :Ulta
    ElseIf #Nb == 36 or #Nb == 38 or #Nb == 40 or #Nb == 42 or #Nb == 44 or #Nb == 46 or #Nb == 48 or #Nb == 50 or #Nb == 52
		#HitPause = 0
		goto :Ulta
    ElseIf #Nb == 54 or #Nb == 56 or #Nb == 58 or #Nb == 60 or #Nb == 62 or #Nb == 64 or #Nb == 66 or #Nb == 68 or #Nb == 70
		#HitPause = 0
		goto :Ulta
    ElseIf #Nb == 72 or #Nb == 74 or #Nb == 76 or #Nb == 78
		#HitPause = 0
		goto :Ulta

    ElseIf #Nb == 1 or #Nb == 39 or #Nb == 43
		#HitPause = 70		
		goto :SwipeLeft

    ElseIf #Nb == 3 or #Nb == 37
		#HitPause = 1300
		goto :Block
    ElseIf #Nb == 41 or #Nb == 45 or #Nb == 49
		#HitPause = 100
		goto :Block

    Elseif #Nb == 5 or #Nb == 47
		#HitPause = 100
		goto :SwipeRight

    ElseIf #Nb == 7 or #Nb == 9 or #Nb == 11 or #Nb == 13 or #Nb == 15 or #Nb == 17 or #Nb == 19 or #Nb == 21 or #Nb == 23 or #Nb == 25
		#HitPause = 150 
		goto :LAttack
    ElseIf #Nb == 27 or #Nb == 29 or #Nb == 31 or #Nb == 33 or #Nb == 35 or #Nb == 51 or #Nb == 53 or #Nb == 55 or #Nb == 57 or #Nb == 59
		#HitPause = 150 
		goto :LAttack
    ElseIf #Nb == 61 or #Nb == 63 or #Nb == 65 or #Nb == 67 or #Nb == 69 or #Nb == 71 or #Nb == 73 or #Nb == 75
		#HitPause = 150 
		goto :LAttack
    ElseIf #Nb == 77
		#HitPause = 120 
		goto :LAttack

    ElseIf #Nb == 79
		#HitPause = 850
		#ChargeHAttack = 850 		
		goto :HAttack

    Endif

    ///////////////////////////////////////////////////////////////////////////////////////

            // Условие выхода из боя.
            GetColor #color #InBattleX1 #InBattleY1
	IF #color < #InBattleC1min or #color > #InBattleC1max
		Sleep 2000

        goto :MarcEnd
    Endif
goto :Bitva9

//==============================================
//Боевая ротация (10).
: Bitva10
# Nb = 0
    : MarcBitva10

 ////////////////////// Последовательнось действий //////////////////////////////

 //свайп влево 
 If #Nb == 0 or #Nb == 1 or #Nb == 2 
#HitPause = 10 
goto :SwipeLeft

//блок 
ElseIf #Nb == 3 
#HitPause = 10 
goto :Block

//свайп вправо 

ElseIf #Nb == 4 or #Nb == 5 or #Nb == 6 or #Nb == 7 or #Nb == 8 
#HitPause = 10 
goto :SwipeRight

//блок 
ElseIf #Nb == 9 
#HitPause = 100 
goto :Block


//лёгкая атака 
//1й удар 
ElseIf #Nb == 10 or #Nb == 11 or #Nb == 12 or #Nb == 13 or #Nb == 14 
#HitPause = 50 
goto :LAttack

//блок 
ElseIf #Nb == 15 
#HitPause = 100 
goto :Block


//2й удар 
ElseIf #Nb == 16 or #Nb == 17 or #Nb == 18 or #Nb == 19 or #Nb == 20 
#HitPause = 50 
goto :LAttack

//блок 
ElseIf #Nb == 21 
#HitPause = 100 
goto :Block

//3й удар 
ElseIf #Nb == 22 or #Nb == 23 or #Nb == 24 or #Nb == 25 or #Nb == 26 
#HitPause = 50 
goto :LAttack

//блок 
ElseIf #Nb == 27 
#HitPause = 100 
goto :Block


//4й удар 
ElseIf #Nb == 28 or #Nb == 29 or #Nb == 30 or #Nb == 31 or #Nb == 32 
#HitPause = 50 
goto :LAttack

//блок 
ElseIf #Nb == 33 or #Nb == 34 or #Nb == 35 or #Nb == 36 or #Nb == 37 
#HitPause = 100 
goto :Block


ElseIf #Nb == 38 
#HitPause = 20 
goto :Ulta

Endif
    ///////////////////////////////////////////////////////////////////////////////////////

            // Условие выхода из боя.
            GetColor #color #InBattleX1 #InBattleY1
	IF #color < #InBattleC1min or #color > #InBattleC1max
		Sleep 2000

        goto :MarcEnd
    Endif
goto :Bitva10


//==============================================

: end

        }
    }
}
