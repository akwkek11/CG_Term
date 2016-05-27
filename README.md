# Computer Graphics Proposal

* 2013210101 반용휴
* 2014210009 주어진
* 2015410057 김기찬

## 1. Environment

* Target Version : Android 6.0 MarshMellow API 23
* Least Version : Android 4.3 JellyBean API 18
* Language : C / C++ with NDK ( in Qt ) + Java or Unity
* ( We are coding vertex shader mainly inserting many of arithmetic operations. )

## 2. Introduction of Theme for the Term Project

 Impossible Object ( Such as Mobile Game “Monument Valley”, Penrose stairs, etc… )

 Impossible Object = optical illusion ( in CG, Camera illusion ), 2D figure -> a projection of a 3D object입니다. ( Game중 Impossible Object를 잘 활용한 Monument Valley에서 잘 표현되어 있습니다. )

![Figure 1.](http://blog.allmyfaves.com/wp-content/uploads/2014/04/Monument-Valley-was-designed-to-be-played-while-wearing-headphones-and-the-use-of-earbuds-or-headphones-definitely-enhances-the-experience..png)

< Figure 1. Mobile Game using impossible objects >

 저희는 실제로 불가능한 물체들을 Rendering할 것입니다. 물론 Object는 하나가 아닌 여러 경우에서의 ‘Objects’를 의미합니다. 
 Impossible Object의 착시가 일어날 때 무한히 빨라지는 공을 만들 예정입니다. 즉, Camera와 공에 적당한 트릭을 이용할 것입니다.

착시 상태일 때 공이 계속 내려가 빨라지는 모습, 착시 상태가 아닐 땐 공이 길에서 벗어나는 모습을 볼 수 있습니다.

## 3. 역할

* Impossible object(경사로) 만들기, 허공 밑으로 공이 너무 멀리 떨어져 있을 때 제거 – 김기찬
* 현재 시선이 착시를 일으키는 위치에 있는지 확인 – 주어진
* 공이 꾸준히 가속도를 받으며 내려가는 모습 구현 – 반용휴