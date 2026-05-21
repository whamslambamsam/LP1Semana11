```mermaid
classDiagram
Program : Main()
Program : Program()
Program : Start()
Program : ShowMenu()
Program : InsertPlayer()
Program : ListPlayers()
Program : ListPlayersWithScoreGreaterThan()
Program : GetPlayersWithScoreGreaterThan()
Program : SortPlayerList()

class IComparer <<interface>>

Player : Player()
Player : override ToString()
Player : CompareTo()

CompareByName : Compare()
CompareByName : CompareByName()

class PlayerOrder

IComparer <|.. Player
IComparer <|.. CompareByName
Player <.. Program
CompareByName <.. Program
PlayerOrder <.. Program
```