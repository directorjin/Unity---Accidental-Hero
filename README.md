# Unity-Game---an-accidental-hero
Unity Game/Action/Puzzle
  
  
  
ソースコードを見る前に読んでください.docをダウンロードして先に読んでください。
---------------
  
  
  

Description
===========
  
このゲームはユニティで作られています。(The game was produced by Unity.)
----------------------------------------------
これは4つのステージに分けられています。(It's divided into four stages.)
---------------------------------------------
私がプログラミングしたステージは'3,4番ステージ'です。(The stage I programmed is and 3 and 4.)
------------------------------------------------------------
チームの同僚は、書類作成と'1,2'ステージそしてタイトルを担当しました。(A colleague of the team worked on paperwork, 1 stage,2 stage, title)    
-------------------------------------------------------------



_Q : このゲームを作った理由?_  

_A : 主人公がモンスターを攻撃してレベルアップし、アイテムを得て強くなる伝統的なRPGではなく、少し様々な方法でステージをクリアしていくゲームを作ってみたかったからだ。  
その理由は二つある。  
  
1.、ユニティを使用して様々な機能をプログラミングしてみたくて(プログラマーで)
2.プレーヤーが多様な面白みを感じることを願って(ゲームクリエーターで)_
  
  

<hr/>  

**1. 最初のステージは、基本的な操作法を身につけるためのステージです。 (The first stage is survival stage for the tutorial.)**

<hr/>

  
Stage1 - Rule
----
プレイヤーは火の近くにいるとHPが回復します。 しかし、火の近くではHPが減少します。(Here, the player have to fills up the health near the fire and moves on to find the next one.)
だからHPが0にならないように火を引きながら到着地を見つける必要があります。(Be careful not to get zero health in the cold.)
  
Stage2 - ScreenShot
----
  
<img width="700" src="https://user-images.githubusercontent.com/44941601/73856050-3f177a00-4878-11ea-8e16-7e3893c47896.png">    
  
もし火と離れているとHPが減少します。(If you're not near fire, your health will continue to fall.)
  
<img width="700" src="https://user-images.githubusercontent.com/44941601/73856295-9289c800-4878-11ea-8596-212afdb8a706.png">    
  
火の近くにいると減少したHPが回復します。(If you're near fire, you'll recover your failing health.)
  
<img width="700" src="https://user-images.githubusercontent.com/44941601/73856442-d250af80-4878-11ea-98e1-a65a8721ecb2.png">    
  
到着点に着いたらCutSceneが始まります。(CutScene will play back when you arrive at the final point while maintaining health.)
  
  



<hr/>  
  
**2. 二番目のステージはゴブリンとの戦闘です。(The second stage is fighting stage against Goblin.)**

<hr/>
  

  
Stage2 - Rule
----
  
ゴブリンは決められた場所をパトロールします。もしプレイヤーを見つけたら接近します。(Goblin patrols the designated area. If Goblin detects the player, it approaches.)
しかし、プレイヤーと距離が離れると、ゴブリンはまた元の位置に戻ってパトロールします。(However, as the distance between Goblin and the player becomes remote, they return to their original positions and patrol the designated areas.)
プレイヤーはBoxを獲得してトラップをインストールします。トラップでゴブリンを処理します。(The player installs traps and attracts and kills goblin.)
プレイヤーはトラップを設置するのに時間が必要です。 ですから、プレイヤーはトラップを設置する前に、適当な位置を考えなければなりません。(The player takes time to install the trap, so the player has to think carefully about it.)
  
Stage2 - ScreenShot
----
<img width="700" src="https://user-images.githubusercontent.com/44941601/73856749-4ab77080-4879-11ea-9464-a5074805f88a.png">   
  
ゴブリンは設定された場所をパトロールします。(Goblin patrols each set of places.)
  
<img width="700" src="https://user-images.githubusercontent.com/44941601/73857777-bcdc8500-487a-11ea-98ce-7076ec78cf3b.png">   
  
プレイヤーはトラップを取り付け、ゴブリンを誘引します。(The player installs the trap and pulls the goblin onto the trap to kill.)

  
  


<hr/>  
  
**3. 三番目のステージは3D氷の洞窟ステージだ。(The third stage is puzzle stage like Pokémon's ice cave.)**


<hr/>
  
<img width="700" src="https://user-images.githubusercontent.com/44941601/74649341-aa3f4580-51c2-11ea-8cb2-ba1ef478bb7e.png">
_ポケモンゴールドの氷の洞窟がモチーフ。
モチーフにした理由は二つある。
1.今までしたゲームの中のパズルの中で一番面白かった。
2.3Dゲームの中で、2Dの論理を使用してみたかった。_
  
Stage3 - Rule
----
プレイヤーは氷の上では左、右、上、下でのみ移動できる。移動方向を決めると氷の上で滑る。(The player slides on the ice. So we have to go in four directions.)
過ぎ去ったエリアはX表示され、X表示に戻るとステージがリセットされます。それで同じ場所を一度以上過ぎることはできません。(You can't go back to where you've been. because Such situation leads to a reset.)
  
  
Stage3 - ScreenShot
----
<img width="700" src="https://user-images.githubusercontent.com/44941601/73858331-923efc00-487b-11ea-97ea-3544df0659b5.png"> 
プレイヤーは氷の上で滑ります。 滑った時のキーボード入力はできません。(The player cannot operate the keyboard on the ice.)
  
<img width="700" src="https://user-images.githubusercontent.com/44941601/73858574-f6fa5680-487b-11ea-81a7-a2147578bcdb.png"> 
同じ場所を一度以上通ることはできません。(Once you've passed, it's an X mark. If you go to the place marked X, the puzzle is initialized.)




<hr/>  
  
**4. 4番目のステージは、パターンのあるボスモンスターとの戦闘です。(The fourth stage is fight the boss who have the 3 pattern.)** 

<hr/>
  
_MMORPGゲームでよく登場するパターンのあるボスを作ってみたかったのです。 2番目のステージでプログラミングできなかった精密な一つのボスAIを作りました。_


Stage4 - Rule
----
ボスは三つのパターンを持っています。(The boss has three attack patterns.)
毒唾を吐き、魔法を使い、ダッシュをします。(Poisonous needles spitting, magical star, dash.)
しかし、ダッシュパターンでプレイヤーがダッシュを避けると、ボスは壁に頭を打ち込んでボスのHPが減少します。(The boss loses his health when he hits his head against a wall during a dash pattern.)
  
  
Stage4 - ScreenShot
----
<img width="700" src="https://user-images.githubusercontent.com/44941601/73859082-d54d9f00-487c-11ea-9e57-f183ff5dfcf7.png"> 
毒唾を吐くこと(Poisonous needles spitting. )
3方向の毒唾を吐きます。 中央の毒針はプレイヤーに向いています。(Fire three poisoned needles, including the player's current position.)
  
<img width="700" src="https://user-images.githubusercontent.com/44941601/73859212-08902e00-487d-11ea-937b-7983ec178c5b.png"> 
魔法(magical star.)
魔法を使うと床にピンク色の道が見えます。 その道にボスの魔法が移動します。プレイヤーはピンクの道を見て自らの位置を考えなければなりません。(Goblin uses magic to create a pink road on the floor, and two seconds later, stars are created and moved to the pink road. When you touch a star, you lose your health.)
  
<img width="700" src="https://user-images.githubusercontent.com/44941601/73859640-b00d6080-487d-11ea-9154-e9a9cc50a8cb.png"> 
魔法を使った後、ボスはダッシュをします。(After using the magic pattern, Goblin uses the dash pattern.) 
プレイヤーがボスのダッシュを避けると、ボスは壁にぶつかってボスのHPが減少します。(When the player avoids the goblin dash, the goblin hits his head against a wall and lose his health.)
  
<img width="700" src="https://user-images.githubusercontent.com/44941601/73859837-07abcc00-487e-11ea-8b14-d7118146d5b2.png"> 
ボスのHPが0になるとエンディンシンが出ます。(When Goblin's health reaches zero, the player wins and the ending scene begins.)
  
<hr/>  
  
Play Video
-----------
https://www.youtube.com/watch?v=AG4v-685a7o


<hr/> 
  
反省
---------
UNI.Tを初めて学んで作ってみたゲームだったので、たくさんのバグがあった。
そして、初めてチームプロジェクトをしてみたので、協業過程でも多くのバグができた。
チームプロジェクトは結局、二人の人が一つのプログラムを作る作成ので、すっきりとコーディングしてコメントも詳しく作成して、変数の名前の付け方やいろいろなことを事前に話し合って統一しなければならないことも感じた。


<hr/> 
  
開発環境
--------
2018.8.1 Unity 
