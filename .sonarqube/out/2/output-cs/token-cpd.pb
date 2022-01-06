º	
uC:\Users\Baptiste\Documents\HES SO Valais\56 Software industrialization\Ner-Agile-Redmine\BLL\IInstallationManager.cs
	namespace 	
BLL
 
{ 
public 

	interface  
IInstallationManager )
{ 
int 
AddInstallation 
( 
string "
street# )
,) *
int+ .
number/ 5
,5 6
int7 :
postcode; C
,C D
stringE K
cityL P
,P Q
stringR X
energyY _
,_ `
stringa g
integrationh s
,s t
stringu {
pvCells	| ƒ
,
ƒ „
double
… ‹
orientation
Œ —
,
— ˜
double
™ Ÿ
roof
  ¤
,
¤ ¥
double
¦ ¬
length
­ ³
,
³ ´
double
µ »
width
¼ Á
,
Á Â
double
Ã É
area
Ê Î
)
Î Ï
;
Ï Ð
Installation 
GetInstallation $
($ %
int% (
registrationNumber) ;
); <
;< =
}		 
}

 „
tC:\Users\Baptiste\Documents\HES SO Valais\56 Software industrialization\Ner-Agile-Redmine\BLL\InstallationManager.cs
	namespace		 	
BLL		
 
{

 
public 

class 
InstallationManager $
:% & 
IInstallationManager' ;
{ 
private 
IInstallationDB 
InstallationDB  .
{/ 0
get1 4
;4 5
}6 7
public 
InstallationManager "
(" #
IInstallationDB# 2
installationDB3 A
)A B
{ 	
InstallationDB 
= 
installationDB +
;+ ,
} 	
public 
Installation 
GetInstallation +
(+ ,
int, /
registrationNumber0 B
)B C
{ 	
return 
InstallationDB !
.! "-
!getInstallationByRegisteredNumber" C
(C D
registrationNumberD V
)V W
;W X
} 	
public 
int 
AddInstallation "
(" #
string# )
street* 0
,0 1
int2 5
number6 <
,< =
int> A
postcodeB J
,J K
stringL R
cityS W
,W X
stringY _
energy` f
,f g
stringh n
integrationo z
,z {
String 
pvCells 
, 
double "
orientation# .
,. /
double0 6
roof7 ;
,; <
double= C
lengthD J
,J K
doubleL R
widthS X
,X Y
doubleZ `
areaa e
)e f
{ 	
return 
InstallationDB !
.! "
AddInstallation" 1
(1 2
street2 8
,8 9
number: @
,@ A
postcodeB J
,J K
cityL P
,P Q
energyR X
,X Y
integrationZ e
,e f
pvCellsg n
,n o
orientationp {
,{ |
roof	} 
,
 ‚
length
ƒ ‰
,
‰ Š
width
‹ 
,
 ‘
area
’ –
)
– —
;
— ˜
} 	
} 
}   