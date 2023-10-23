```mermaid
---
title: Diagrama entidad relacion
---
erDiagram
    User {
        string id PK
        string name
        string surname
        string email
        string login
        string password
        date createdDate
        enum status "estado del usuario"
        boolean isVerified "verificacion del email"
    }
    User ||--o| NaturalPerson : is
    User ||--o| LegalPerson : is
    User ||--o| Contribution : make
    User ||--o{ PaymentMethod : has
    User ||--o{ ChangePasswordRequest : request
    User ||--o{ SupportTicket : creates

    LegalPerson {
        string id PK
    }
    LegalPerson ||--|| NaturalPerson : represent

    NaturalPerson {
        string id PK
    }
    NaturalPerson ||--o{ Campaign : create
    NaturalPerson ||--o| Channel : create
    NaturalPerson ||--o| Admin : is

    Admin {
        string id PK
    }
    Admin ||--o{ SupportTicket : attend
    Admin ||--o{ LegalPerson : verify
    
    Contribution {
        date paymentDate
        number amount
        
    }
    Contribution ||--o| PaymentMethod : Use

    Channel {
        string id PK
        string createdBy
        date createdDate
        date modifiedDate
        string modifiedBy
    }
    Channel ||--o| ChannelState : has
    Channel ||--|| Contribution : receive

    ChannelState {
        string id PK
        string chanel_id FK
        enum status
        string createdBy
        date createdDate
    }      
    Category ||--|{ SubCategory : contains 
    Category {
        string id PK
        string name
        string description
        enum status
        date createdDate 
        string createdBy
        date modifiedDate
        string modifiedBy
    }
    SubCategory {
        string id PK
        string name
        string description
        string category_id FK "category id"
        enum status
        date createdDate 
        string createdBy
        date modifiedDate
        string modifiedBy
    }
    Campaign ||--o{ ProgressReport : has
    Campaign ||--|| SubCategory : has
    Campaign ||--o{ Milestone : has
    Campaign ||--o{ Rewards : has
    Campaign ||--|{ CampaignItems : need
    Campaign ||--|{ CampaignState : has
    Campaign ||--|{ Contribution : receive
    Campaign ||--|{ preValidationProof : has
    Campaign ||--|{ postValidationProof : has

    Campaign {
        string id PK
        string title
        string description
        string personal
        date startDate
        date endDate
        enum type "enum to describe campaign types"
        string sub_category_id FK "sub category id"
        boolean preValideted
        boolean postValideted
        date createdDate 
        string createdBy
        date modifiedDate
        string modifiedBy
    }
    CampaignState {
        string id PK
        string campaign_id FK "campaign id"
        enum status
        string createdBy
        date createdDate
    }  
    CampaignItems {
        string id PK
        string campaign_id FK "campaign id"
        string name
        string description
        number amount
        number price
        string createdBy
        date createdDate
        date modifiedDate
        string modifiedBy
    }
    ProgressReport {
        string id PK
        string campaign_id FK "campaign id"
        string description
        date createdDate 
        string createdBy
        date modifiedDate
        string modifiedBy
    }
    Milestone {
        string id PK
        string campaign_id FK "campaign id"
        string description
        number amountTarget "amount of money to complete the milestone"
        date limitDate
        date createdDate 
        string createdBy
        date modifiedDate
        string modifiedBy
    }
    Rewards {
        string id PK
        string campaign_id FK "campaign id"
        string name
        string description
        number minAmount
        date createdDate 
        string createdBy
        date modifiedDate
        string modifiedBy
    }

    preValidationProof {
        string id PK
        string campaign_id FK "campaign id"
        file document
        date uploadDate
        string uploadedBy FK "User id"
        string status
        string attendedBy FK "Admin id"
    }

    postValidationProof {
        string id PK
        string campaign_id FK "campaign id"
        file document
        date uploadDate
        string uploadedBy FK "User id"
        string status
        string attendedBy FK "Admin id"
    }

    PaymentMethod {
        string id PK
    }

    ChangePasswordRequest {
        string id PK
        date dateRequest
        string user_id FK "User id"
        string url
        boolean used
        boolean expired
    }

    SupportTicket {
        string id PK
        string createdBy FK "User id"
        date createdAt
        string attendedBy FK "Admin id"
        string status
        string ticketType
        string description
        string result
    }

    
    SupportTicket ||--o| FraudClaim : is
    FraudClaim {
        string acussed FK "User id"
    }
    FraudClaim ||--o| User : acusse
    
```

---

### Estados (baja logica)

Para evitar usar **borrado en cascada** en entidades criticas como usuario, camapaña, etc. Vamos a utilizar un estado interno para identificar esta situación.

- Activo

- Inactivo
    

### Auditoria

Para mantener **trazabilidad** de los cambios en las distintas entidades vamos a registrar los siguientes datos:

- Fecha de creación

- Creado por

- Fecha de modificación

- Modificado por
