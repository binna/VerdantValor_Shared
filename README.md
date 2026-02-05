# Verdant Valor Shared Project (2025.10.18 ~ 진행 중)

서버와 클라이언트가 공통으로 사용하는 `.cs` 및 `.json` 파일을 관리하는 공유 프로젝트입니다.    

<br><br>

## 구성
클라이언트와 서버에서 공유하는 파일을 다음과 같이 **3개의 라이브러리로 구분**합니다.    

1. [**채팅 서버 프로토콜**](./Protocol/Chat)
2. [**웹 서버 프로토콜**](./Protocol/Web)
3. [**공통**](./Shared)
   - [상수](./Shared/Constants)
   - [GameData](./Shared/GameData)
   - [타입 (Enum 또는 readonly struct)](./Shared/Types)
