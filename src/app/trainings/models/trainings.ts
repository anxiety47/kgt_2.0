export interface DogTraining {
  id: string;
  delayTime: string;
  duration: string;
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
  dogStartTime: Date;
}

export interface LostPersonTrackData {
  lostPersonName: string;
  lostPersonTrackPoints: TrackPoint[];
  lostPersonTrailLength: string;
  lostPersonStartTime: Date;
}


export interface TrackPoint {
  lat: number;
  lng: number;
  time: Date;
}
