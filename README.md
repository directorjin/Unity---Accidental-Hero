# Unity-Game---an-accidental-hero
Unity Game/Action/Puzzle  
  
<hr/>    
  
_" ソースコードを見る前に読んでください.doc "をダウンロードして先に読んでください。_
---------------
  
SourceCodeフォルダはポートフォリオの評価が便利になるようにScriptファイルだけを集めたものです。  assetフォルダにあるものと同じです。  
----------------

  
<hr/>  
  
Play Video
-----------
Stage 3 : https://www.youtube.com/watch?v=l9sI75ccc0A
  
Stage 4 : https://www.youtube.com/watch?v=jQYbrPY2nrU

<hr/> 
      
Description
===========
  
このゲームはユニティで作られています。(The game was produced by Unity.)
----------------------------------------------
このゲームは4つのステージに分けられています。(It's divided into four stages.)
---------------------------------------------
私がプログラミングしたステージは'2,3,4ステージ'です。(The stage I programmed is number 2 and 3 and 4.)
------------------------------------------------------------
チームのスタッフは、書類作成と1ステージ、グラフィック、サウンド、タイトルとエンディングを担当しました。(A colleague of the team worked on paperwork, one stage, graphics, sound, titles, and endings.)    
-------------------------------------------------------------



_Q : このゲームを作った理由?_  

_A : 主人公がモンスターを攻撃してレベルアップし、アイテムを得て強くなる伝統的なRPGではなく、様々な方法でステージをクリアしていくゲームを作ってみたかったからだ。    
その理由は二つある。  
    
1.、ユニティを使用して様々な機能をプログラミングしてみたくて(プログラマーとして)
2.プレーヤーが多様な面白みを感じることを願って(ゲームクリエーターとして)_
    
    
  
<hr/>  

**1. 最初のステージは、基本的な操作方法を身につけるためのステージです。 (The first stage is survival stage for the tutorial.)**

<hr/>

  
Stage1 - Rule
------
プレイヤーは火の近くにいるとHPが回復します。 しかし、火から離れるとHPが減少します。(Here, the player have to fills up the health near the fire and moves on to find the next one.) 
そのためHPが0にならないように火を探しながら目的地を見つける必要があります。(Be careful not to get zero health in the cold.)
  
Stage2 - ScreenShot
------
  
<img width="700" src="https://user-images.githubusercontent.com/44941601/73856050-3f177a00-4878-11ea-8e16-7e3893c47896.png">    
  
火から離れるとHPが減少します。(If you're not near fire, your health will continue to fall.)
  
<img width="700" src="https://user-images.githubusercontent.com/44941601/73856295-9289c800-4878-11ea-8596-212afdb8a706.png">    
  
火の近くにいくと減少したHPが回復します。(If you're near fire, you'll recover your failing health.)
  
<img width="700" src="https://user-images.githubusercontent.com/44941601/73856442-d250af80-4878-11ea-98e1-a65a8721ecb2.png">    
  
目的地に着いたらCutSceneが始まります。(CutScene will play back when you arrive at the final point while maintaining health.)
  
  



<hr/>  
  
**2. ステージ２はゴブリンとの戦闘です。(The second stage is fighting stage against Goblin.)**

<hr/>
  
Stage2 - Rule
----
  
ゴブリンは決められた場所をパトロールします。もしプレイヤーを見つけたら接近します。(Goblin patrols the designated area. If Goblin detects the player, it approaches.) 
しかし、プレイヤーと距離が離れると、ゴブリンはまた所定の位置に戻ってパトロールします。(However, as the distance between Goblin and the player becomes remote, they return to their original positions and patrol the designated areas.)  
プレイヤーはBoxを獲得してトラップをインストールします。トラップでゴブリンを倒すことが出来ます。(The player installs traps and attracts and kills goblin.) 
プレイヤーはトラップを設置するのに時間がかかります。 ですから、プレイヤーはトラップを設置する前に、適当な位置を考えなければなりません。(The player takes time to install the trap, so the player has to think carefully about it.) 
  
Stage2 - ScreenShot
----
<img width="700" src="https://user-images.githubusercontent.com/44941601/73856749-4ab77080-4879-11ea-9464-a5074805f88a.png">   
  
ゴブリンは特定の場所をパトロールします。(Goblin patrols each set of places.)
  
<img width="700" src="https://user-images.githubusercontent.com/44941601/73857777-bcdc8500-487a-11ea-98ce-7076ec78cf3b.png">   
  
プレイヤーはトラップを取り付け、ゴブリンを誘引します。(The player installs the trap and pulls the goblin onto the trap to kill.)

  
  


<hr/>  
  
**3. ステージ３は3D氷の洞窟ステージです。(The third stage is puzzle stage like Pokémon's ice cave.)**


<hr/>
  
<img width="700" src="https://user-images.githubusercontent.com/44941601/74649341-aa3f4580-51c2-11ea-8cb2-ba1ef478bb7e.png">
_ポケットモンスターゴールドの氷の洞窟がモチーフ。 
モチーフにした理由は二つある。
1.今までしたダンジョンの中で一番面白かった。
2.3Dゲームに、2Dの論理を応用してみたかった。_
  
Stage3 - Rule
----
プレイヤーは氷の上では上、下、左、右にのみ移動できます。移動方向を決めると氷の上を滑ります。(The player slides on the ice. So we have to go in four directions.)  
通ったエリアにはXが表示され、Xエリアに戻るとステージがリセットされます。同じ場所を二度滑ることはできません。(You can't go back to where you've been. because Such situation leads to a reset.) 
  
  
Stage3 - ScreenShot
----
<img width="700" src="https://user-images.githubusercontent.com/44941601/73858331-923efc00-487b-11ea-97ea-3544df0659b5.png"> 
プレイヤーは氷の上を滑ります。 滑ってる間キーボード入力はできません。(The player cannot operate the keyboard on the ice.)
  
<img width="700" src="https://user-images.githubusercontent.com/44941601/73858574-f6fa5680-487b-11ea-81a7-a2147578bcdb.png"> 
同じ場所を二度通ることはできません。(Once you've passed, it's an X mark. If you go to the place marked X, the puzzle is initialized.)




<hr/>  
  
**4. ステージ４は、パターンのあるボスモンスターとの戦闘です。(The fourth stage is fight the boss who have the 3 pattern.)** 

<hr/>
  
_MMORPGゲームでよく登場するパターンのあるボスを作ってみたかったです。 ステージ２ではプログラミングできなかった精密なボスAIを作りました。_


Stage4 - Rule
----
このステージでプレイヤーにはステミナが存在します。ステミナの回復のために走ることを休むことも必要し、ボスの攻撃を避けるためにステミナを使って走ることも必要です。(In this stage, the player needs to take a break from running to recover the stamina, and use the stamina to avoid attacking the boss.) 
ボスは三つのパターンを持っています。(The boss has three attack patterns.) 
①毒唾を吐き②魔法を使い③ダッシュします。(Poisonous needles spitting, magical star, dash.)  
ダッシュパターンの際、プレイヤーが突進を避けると、ボスは壁に頭を打ち込んでHPが減少します。(The boss loses his health when he hits his head against a wall during a dash pattern.) 
  
  
Stage4 - ScreenShot
----
<img width="700" src="https://user-images.githubusercontent.com/44941601/75559881-9976b580-5a87-11ea-8cfc-ba6b77dccbfc.png"> 
Shiftを押して走るとステミナが減少します。歩けばステミナが回復します。ボスの攻撃によって、プレイヤーはいつ走るかをよく考える必要があります。(Running reduces the stamina.(Run key : press Shift Button) Walking will restore the stamina. Depending on the boss's attack, the player must think carefully when to run.)

<img width="700" src="https://user-images.githubusercontent.com/44941601/75559522-f0c85600-5a86-11ea-8fa0-02e24bb84a26.png"> 
毒唾を吐く(Poisonous needles spitting. ) 
プレーヤーの方向に3度の毒針を発射します。(Fire three poisoned needles, the way is the player's current position.)
  
<img width="700" src="https://user-images.githubusercontent.com/44941601/73859212-08902e00-487d-11ea-937b-7983ec178c5b.png"> 
魔法(magical star.)
魔法を使うと床にピンク色の道が見えます。 その道にボスの魔法が移動します。プレイヤーはピンクの道を見て攻撃をよけなければなりません。(Goblin uses magic to create a pink road on the floor, and two seconds later, stars are created and moved to the pink road. When you touch a star, you lose your health.)
  
<img width="700" src="https://user-images.githubusercontent.com/44941601/73859640-b00d6080-487d-11ea-9154-e9a9cc50a8cb.png"> 
魔法を使った後、ボスはダッシュします。(After using the magic pattern, Goblin uses the dash pattern.) 
プレイヤーがボスのダッシュを避けると、ボスは壁にぶつかってHPが減少します。(When the player avoids the goblin dash, the goblin hits his head against a wall and lose his health.)
  
<img width="700" src="https://user-images.githubusercontent.com/44941601/75558694-8b279a00-5a85-11ea-9f51-e711b73ebb38.png"> 
ボスのHPが半分で怒り状態になります。 パターンがランダムになりパターンの待ち時間が短くなります。 そして、魔法を使えばもっと多くの星が生成されます。(If the Boss's Hp is less than the Half, then Boss's State turn to the Rage mode. Rage mode is more speedy and the magic is more powerful.) 

<img width="700" src="https://user-images.githubusercontent.com/44941601/73859837-07abcc00-487e-11ea-8b14-d7118146d5b2.png"> 
ボスのHPが0になるとエンディングが流れます。(When Goblin's health reaches zero, the player wins and the ending scene begins.)
  
<hr/> 
  
反省
---------
Unityを学んで初めて作ってみたゲームだったので、たくさんのバグがあった。  
初めてのチームプロジェクトだったので、協業過程でも多くの課題もできた。 
すっきりとコーディングされた詳しいコメントの作成、変数の名前の付け方や詳細を事前に話し合って統一しなければならないことを感じた。  


<hr/> 
  
開発環境
--------
2018.8.1 Unity (2019.3.1f 互換性あり)
