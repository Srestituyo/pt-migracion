import { IonButton, IonCard, IonCardContent, IonCardHeader, IonCardSubtitle, IonCardTitle, IonContent, IonHeader, IonIcon, IonItem, IonLabel, IonPage, IonTitle, IonToolbar } from '@ionic/react';

import './Persona.css';

const Persona: React.FC = () => {
  return ( 
    <IonPage>
      <IonHeader>
        <IonToolbar>
          <IonTitle>Lista de Persona</IonTitle>
          <IonButton slot="primary">Agregar Persona</IonButton>
        </IonToolbar>
      </IonHeader>
      <IonContent>
        <IonCard>
          <IonCardHeader>
            <IonCardSubtitle>Card Subtitle</IonCardSubtitle>
            <IonCardTitle>Card Title</IonCardTitle>
          </IonCardHeader> 
          <IonCardContent>
            Keep close to Nature's heart... and break clear away, once in awhile,
            and climb a mountain or spend a week in the woods. Wash your spirit clean.
          </IonCardContent>
          </IonCard> 
      </IonContent>
    </IonPage>
  );
};

export default Persona;
