# Object Avoid
만든이: 백재영

<a href="https://github.com/100wodud"><img src="https://img.shields.io/badge/Github-100wodud-blue?logo=github&style=for-the-badge"/></a>

# Object Avoid??

<img src="https://i.ibb.co/rvv39F8/1.png" alt="2020-12-21-1-27-21" border="0" width="">

랜덤하게 나오는 총알과 위아래로 나오는 벽을 피해 최대한 오래 버티는 게임

캐릭터는 좌우로는 움직일 수 있으나 상하로 움직일 수 없습니다. 

대신 space키를 이용해 버티기가 가능합니다.

<img src="https://i.ibb.co/ctGdHpq/2.png" alt="2020-12-21-1-27-21" border="0" width=""><img src="https://i.ibb.co/ygkDV93/1.png" alt="2020-12-21-1-27-21" border="0" width="">

1. 나오는 모든 총알과 벽은 Object Pool을 이용해 메모리 간소화
2. 맵은 무한 생성이 아닌 스크롤링을 이용
3. 원근감을 위해 패럴렉스 방식 사용
4. DataManager를 통한 최고점수 저장
5. 메인 글씨 반짝임을 위해 DOTween의 Fade기능 사용

   <a href="https://dotween.demigiant.com/index.php">https://dotween.demigiant.com/index.php</a>
  
# Trouble Shooting
1. 문제점
   
GameManager에 Object Pool 스폰 기능을 넣는 바람에
```
DontDestroyOnLoad(this.gameObject);
```
를 사용하지 못하여 Scene이 초기화 될 시 Score가 저장 되지 않는 문제가 생겼다.


2. 해결방법
   
GameManager는 포기하고 게임이 시작할시 계속 초기화를 해주었다.
대신 점수만을 위한 DataManger를 생성하고 파괴되지 않게 코드를 짜주었다.
이 방법으로 Save / Load 기능도 구현이 가능 할 것 같고 JSON 파일을 만들어주는 중간 역할도 해줄 수 있다.
   
