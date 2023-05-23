# GarticUmm

♥️ Team. Umm 프로젝트 제안서 ☠️\
🌸 Umm.. 고민하며 Umm.. 생각하며 개발하는 Umm team 입니다! 🌼

</br>

## 프로젝트 주제명

**Galtic-Umm**

</br>

## 프로젝트 주제에 대한 설명

Umm 팀에서 Galtic phone이라는 게임에 영향을 받아 그 게임을 참고하여\
window form에서 소켓 통신을 이용해 Galtic 멀티플레이 게임을 만들고자 합니다.

### 기본적인 게임의 진행방식은 다음과 같습니다.

1.	모든 사람이 각각의 제시어를 정한다.
2.	정한 제시어에 해당하는 그림을 제한시간 이내에 그린다.
3.	그린 그림은 제한시간이 지나면 자동으로 다음 사람에게 넘어간다.
4.	다음 사람은 그림을 받으면 그 그림이 의미하는 바를 유추하여
제한 시간 이내에 그림을 새로 그린다.
5.	제한 시간이 지나면 자동으로 그림이 다음 사람에게 넘어간다.
6.	n명의 플레이어가 있다고 칠 때,

### 예시를 들어 설명해봅시다.

1. `1턴`에는 본인이 제시어를 정하고 그림을 그린다.
2. `2, 3, … n-1턴`에는 받은 그림에 대한 그림을 그린다.
3. `n턴`에는 받은 그림이 무엇인지 유추하여 답을 제시한다.
4. 1턴에서 제시한 `제시어와 비교`하며 웃는다.

</br>

## 프로젝트 개발환경
1.	Window 10, 11에서 Visual Studio 2022 와 git을 이용하여 개발
2.	Macos 13.2 에서 UTM을 통한 Windows 11 Arm preview에서 Visual Studio 2022 와 git을 이용하여 개발

</br>

## 프로젝트 일정

| 기간 | 세부계획 |
|---|---|
| 4/13 ~ 4/19 |	레이아웃(UI) 디자인 |
| 4/20 ~ 4/26 |	디자인에 대한 기능 구현(1) |
| 4/27 ~ 5/3 | 디자인에 대한 기능 구현(2) |
| 5/4 ~ 5/10 | 이미지 직렬화(인코딩/디코딩) 처리 |
| 5/11 ~ 5/17 | 소켓 통신 테스트 |
| 5/18 ~ 5/24 | 제시어, 인코딩 이미지 소켓 통신(1) |
| 5/25 ~ 5/31 | 제시어, 인코딩 이미지 소켓 통신(2), 게임 종료 및 재시작 구현(1) |
| 6/1 ~ 6/7 | 게임 종료 및 재시작 구현(2), 디버깅 및 QA |
| 6/8 ~ 6/14 | 마무리 및 발표 자료 작성 |

</br>

## 프로젝트 역할 분담

`이*재 (Chef) - wjlee611` (총괄 개발 관리) 이미지 직렬화, 디버깅 및 QA\
`김*석 - dsundert` 레이아웃 디자인, 기능 구현\
`문*현 - moonjh000` 게임 시작/종료/재시작 구현\
`정*준 - hoijun` 레이아웃 디자인, 기능 구현

소켓 통신 및 발표 자료 작성은 분할하여 작업

## 코드표

`Base code`

| 코드 번호 | 코드 내용 |
|---|---|
| 1000 | Success |
| 1001 | Critical Error |
| 1002 | Timeout |

`Server code`

| 코드 번호 | 코드 내용 |
|---|---|
| 2000 | Server created |
| 2001 | Server stoped |
| 2002 | Server listened |
| 2003 | Server connected with Client |
| 2004 | Server disconnected with Client |
| 2005 | Client list update |

`Client code`

| 코드 번호 | 코드 내용 |
|---|---|
| 3000 | Client connected in Server |
| 3001 | Client disconnected from Server |
| 3002 | Client connected Error because Server is not running |
| 3003 | Client disconnected Error for incomplete termination |

`Chat code`

| 코드 번호 | 코드 내용 |
|---|---|
| 4000 | Message sended |
| 4001 | Message recieved |
| 4002 | Message Error for Message Size Exceeded |
| 4003 | Message Error for Client connected Error |

`Image code`

| 코드 번호 | 코드 내용 |
|---|---|
| 5000 ||
| 5001 ||

