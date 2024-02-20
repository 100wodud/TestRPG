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
4. 메인 글씨 반짝임을 위해 DOTween의 Fade기능 사용

   <a href="https://dotween.demigiant.com/index.php">https://dotween.demigiant.com/index.php</a>
