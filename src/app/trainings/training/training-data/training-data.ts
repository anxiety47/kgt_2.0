import { DogTraining } from "../../models/trainings";
import { points, pointsBlue } from "../training-map/points";

export const trainingData: DogTraining = {
	id: "1",
	delayTime: "00:30:00",
	duration: "01:30:00",
	weather: "weather info",
	notes: "notes info",
	groundType: "ground info",
	dogTrackData: {
		dogTrackPoints: points,
		dogTrailLength: "321m",
		dogStartTime: new Date("2018-07-22T10:22:39Z")
	},
	lostPersonTrackData: {
		lostPersonName: "Test Testowy",
		lostPersonTrackPoints: pointsBlue,
		lostPersonTrailLength: "456m",
		lostPersonStartTime: new Date("2018-07-22T10:22:39Z")
	}
}
