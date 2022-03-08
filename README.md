# 1. 기능
  - 시리얼 통신을 통해 프로그램을 사용하여 조명 컨트롤러 제어
  - 조명 컨트롤러 16개 채널 중 3개 채널을 사용하여 Ring, Bar, Coxial 조명 제어
     - 시리얼 통신을 사용하여 해당 제품과 호환 가능한 설정 사용 
     - 전체 채널 동시 제어
     - 단일 채널 제어의 경우 딜레이 이슈가 발생
     - 이론상 0 ~ 255의 수치 적용이 가능하나 실제 조명의 한계로 인해 0 ~ 180의 수치 사용
     - off mode로 설정 시 모든 채널 수치 0으로 변경

# 2. 사용 프로그램
| Program | Version | Link |
|---|---|---|
|Visual Studio|2022|https://visualstudio.microsoft.com/ko/vs/whatsnew/|
|Light Controller|L-LIGHT Company LPW1624S|http://www.l-light.co.kr/|
