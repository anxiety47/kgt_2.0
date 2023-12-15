import { DogTraining, TrainingListItem } from "src/app/trainings/models/trainings";
import { TrackPoint } from "src/app/trainings/models/trainings";

export const trainingsList: TrainingListItem[] = [
  {
    id: '1',
    date: new Date(),
    location: 'Kraków',
    address: 'ul. Testowa 12'
  },
  {
    id: '2',
    date: new Date(),
    location: 'Test location',
    address: 'Test address'
  }
];

export const points_trail_1: TrackPoint[] = [
  {
    "lat": 50.0300872140,
    "lng": 19.8871017806,
    "time": new Date("2018-07-22T10:22:39Z")
  },
  {
    "lat": 50.0301286206,
    "lng": 19.8869594559,
    "time": new Date("2018-07-22T10:22:55Z")
  },
  {
    "lat": 50.0301183108,
    "lng": 19.8868150357,
    "time": new Date("2018-07-22T10:23:02Z")
  },
  {
    "lat": 50.0301001221,
    "lng": 19.8866795003,
    "time": new Date("2018-07-22T10:23:10Z")
  },
  {
    "lat": 50.0300646666,
    "lng": 19.8865555320,
    "time": new Date("2018-07-22T10:23:26Z")
  },
  {
    "lat": 50.0300559495,
    "lng": 19.8865517601,
    "time": new Date("2018-07-22T10:23:42Z")
  },
  {
    "lat": 50.0300076697,
    "lng": 19.8865033127,
    "time": new Date("2018-07-22T10:23:54Z")
  },
  {
    "lat": 50.0299589708,
    "lng": 19.8864655104,
    "time": new Date("2018-07-22T10:24:07Z")
  },
  {
    "lat": 50.0298980344,
    "lng": 19.8864468187,
    "time": new Date("2018-07-22T10:24:21Z")
  },
  {
    "lat": 50.0298479944,
    "lng": 19.8864278756,
    "time": new Date("2018-07-22T10:24:35Z")
  },
  {
    "lat": 50.0297879800,
    "lng": 19.8864357546,
    "time": new Date("2018-07-22T10:24:50Z")
  }
];

export const points_trail_2: TrackPoint[]  = [
  {
    "lat": 50.0297007244,
    "lng": 19.8865937535,
    "time": new Date("2018-07-22T10:26:21Z")
  },
  {
    "lat": 50.0296461582,
    "lng": 19.8867224157,
    "time": new Date("2018-07-22T10:26:29Z")
  },
  {
    "lat": 50.0295696314,
    "lng": 19.8868434504,
    "time": new Date("2018-07-22T10:26:31Z")
  },
  {
    "lat": 50.0295289792,
    "lng": 19.8869042192,
    "time": new Date("2018-07-22T10:26:32Z")
  },
  {
    "lat": 50.0294799451,
    "lng": 19.8869874515,
    "time": new Date("2018-07-22T10:26:33Z")
  },
  {
    "lat": 50.0294617563,
    "lng": 19.8870132677,
    "time": new Date("2018-07-22T10:26:38Z")
  }
];

export const trainingData: DogTraining = {
	id: "1",
	delayTime: "00:30:00",
	duration: "01:30:00",
	weather: "weather info",
	notes: "notes info",
	groundType: "ground info",
	dogTrackData: {
		dogTrackPoints: points_trail_1,
		dogTrailLength: "321m",
		dogStartTime: new Date("2018-07-22T10:22:39Z")
	},
	lostPersonTrackData: {
		lostPersonName: "Test Testowy",
		lostPersonTrackPoints: points_trail_2,
		lostPersonTrailLength: "456m",
		lostPersonStartTime: new Date("2018-07-22T10:22:39Z")
	}
}
