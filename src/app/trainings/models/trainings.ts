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
