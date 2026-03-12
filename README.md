# 버튼 잡기 게임 (C# 코딩)

## 개요

-C# 프로그래밍 학습

-핵심기능:
1. 자동 회피 버튼
마우스가 버튼에 닿기만 해도 버튼이 다른 곳으로 이동합니다.
2. 점수 계산 및 게임 오버
버튼을 잡는데 성공하면 +100점, 실패하면 -10점을 계산합니다.
'놓친 횟수'를 기억해 두었다가, 20번이 넘어가면 "Game Over"라고 알려주고 게임을 멈춥니다.
3. 잡을수록 작아지는 버튼
버튼을 클릭해서 잡을 때마다 버튼이 현재 크기에서 10%씩 줄어듭니다. 
4. 게임 오버 후 게임 초기화
게임이 끝나면 도망가던 버튼은 사라지고, '다시 시작' 버튼만 나타납니다.
'다시 시작'을 누르면 점수, 횟수, 버튼 크기를 모두 처음 상태로 되돌려 놓습니다.

-화면구성:
1. 정보 표시창(폼 제목)
게임창 맨 위 제목 표시줄에 현재 점수, 버튼을 놓친 횟수를 실시간으로 보여줍니다.

2. '나를 잡아봐" 버튼
게임이 시작되면 화면 정중앙에 아주 크게 나타납니다.마우스가 닿으면 랜덤한 위치로 도망가고, 클릭에 성공할 때마다 크기가 10%씩 작아지며 난이도가 올라가게 만드는 역할입니다.

3. 결과 및 재도전 
게임이 시작되면 숨겨져 있다가, 20번을 놓쳐서 게임이 끝나면 나타납니다. 게임이 끝나면 "Game Over" 메시지 박스가 뜨면서 "나를 잡아봐" 버튼은 사라지고, 화면 중앙에 '다시 시작' 버튼이 나타나 게임을 처음부터 다시 할 수 있도록 도와줍니다.


## 실행 화면

-1단계(기본 도망 기능 구현) 코드의 실행 스크린샷

실행시
<img width="817" height="497" alt="image" src="https://github.com/user-attachments/assets/d5fbcb51-0e5e-407a-9de1-6eddb555b346" />


마우스를 버튼 위에 올렸을 때 - 버튼의 위치가 바뀌며 폼 제목이 "Catch the button version 1.2"에서 버튼위치라고 바뀌며 버튼의 x, y 좌표가 함께 표시됨
<img width="811" height="492" alt="image" src="https://github.com/user-attachments/assets/a405bb2e-be64-48b9-b641-a168b5e93635" />

<img width="805" height="486" alt="image" src="https://github.com/user-attachments/assets/193f65b6-a84f-40b3-9b16-d05020912b33" />


-2단계(시각적/청각적피드백) 코드의 실행 스크린샷

버튼을 잡았을 때 - “축하합니다” 라는 메세지박스가 뜸
<img width="808" height="485" alt="image" src="https://github.com/user-attachments/assets/67e9c876-44e3-499b-8bb5-5ee441d6af9c" />


-3단계(점수 표시와 점수별 난이도 조정) 코드의 실행 스크린샷

버튼을 놓쳤을 때 - 폼 제목에 점수가 -10으로 표시됨 (한번 놓칠 때마다 -10점씩 추가)
(1번 놓쳤을 때)
<img width="814" height="491" alt="image" src="https://github.com/user-attachments/assets/04b0a852-b1c9-405e-a673-eebbfcd4062b" />

(2번 놓쳤을 때)
<img width="808" height="487" alt="image" src="https://github.com/user-attachments/assets/a3d45eca-b57d-4ddc-aa8c-f2f2eb795112" />

버튼을 잡았을 때 - "축하합니다"라는 메세지와 함께 점수가 +100점 추가되고, 버튼이 작아짐
(1번 잡았을 때)
<img width="809" height="490" alt="image" src="https://github.com/user-attachments/assets/cd0f120d-9684-4e24-a8f5-f47b148b5b4b" />
<img width="814" height="485" alt="image" src="https://github.com/user-attachments/assets/d97b830a-389a-4293-80bf-cf9d406406d8" />

(2번 잡았을 때)
<img width="806" height="487" alt="image" src="https://github.com/user-attachments/assets/af47944e-a741-463a-ab9a-c9232d076c74" />


-4단계(게임 오버 및 리셋) 코드의 실행 스크린샷
(놓쳤을 때마다 폼 제목에 놓친 횟수 추가)
<img width="811" height="488" alt="image" src="https://github.com/user-attachments/assets/157a91f5-a3ae-47cd-bfd3-dc80203c8e8e" />

(20번 놓쳤을 때 - "Game over"이라는 문구가 뜸)
<img width="808" height="481" alt="image" src="https://github.com/user-attachments/assets/61c22fd5-f2fc-4c4f-9fad-97660cc1d29e" />

(Game over 창에서 확인을 누른 후 - 화면에 나타난 "다시 시작" 버튼을 누르면 게임이 처음부터 다시 시작됨)
<img width="809" height="487" alt="image" src="https://github.com/user-attachments/assets/7e9cb8d6-c7a0-4c6b-847d-730ac3f7c8dd" />

("다시 시작" 버튼을 눌렀을 때)
<img width="808" height="492" alt="image" src="https://github.com/user-attachments/assets/532a6e9f-9b69-477d-bae6-fa469753ded3" />


## 구현 시 어려웠던 점

-버튼이 랜덤으로 이동할 때 버튼의 일부가 가려진 부분의 해결법이 어려웠지만, 게임 창 화면의 실제 안쪽 크기에서 버튼 크기를 빼서 해결함.


-버튼이 일정 비율로 줄어들게 만들기 위해 버튼의 크기를 줄이면 글자의 크기가 줄어들지 않아 어려웠지만, 버튼의 속성 창에서 해결함.

-Enter 버튼을 누르면 마우스로 클릭한 것과 똑같이 인식하던 부분을 어떻게 수정해야하는지 몰라 어려웠지만, 배경의 속성 창에서 AcceptButton을 (None)으로 변경하여 해결함.
