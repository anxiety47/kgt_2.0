// TODO: separate to different files

export interface DogTraining {
  id: string;
  delayTime: string;  // format wyświetlania hh.mm.ss
  duration: string;  // format wyświetlania hh.mm.ss
  weather: string;
  notes: string;
  groundType: string;
  // TODO: add attachments (and comments?)

  dogTrackData: DogTrackData;
  lostPersonTrackData: LostPersonTrackData;
}

export interface DogTrackData {
  dogTrackPoints: TrackPoint[];
  dogTrailLength: string;
  dogStartTime: Date;  // format wyświetlania hh.mm.ss
}

export interface LostPersonTrackData {
  lostPersonName: string;
  lostPersonTrackPoints: TrackPoint[];
  lostPersonTrailLength: string;
  lostPersonStartTime: Date;  // format wyświetlania hh.mm.ss
}


export interface TrackPoint {
  lat: number;
  lng: number;
  time: Date;
}


export interface TrainingListItem { // wyświetlanie listy wszystkich treningów
  id: string;
  date: Date; // or string
  location: string;
  address: string;
}

export interface TrainingDetails {  // szczegółowe informacje o konkretnym treningu
  id: string;
  date: Date; // or string
  location: string;
  address: string;
  dogsList: DogTrainingListItem[];
  weather: string;
  notes: string;
}

interface DogTrainingListItem {  // lista psów biorących udział w danym treningu
  dogId: string;
  name: string;
  personName: string;
}