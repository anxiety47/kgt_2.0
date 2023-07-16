import { Component, Input } from '@angular/core';
import { points, pointsBlue } from './points';
import { TrackPoint } from '../models/trainings';
import { MapInfoWindow, MapMarker } from '@angular/google-maps';

@Component({
  selector: 'app-training-map',
  templateUrl: './training-map.component.html',
  styleUrls: ['./training-map.component.scss']
})
export class TrainingMapComponent {

  @Input() dogTrail: TrackPoint[] = points;
  @Input() personTrail: TrackPoint[] = pointsBlue;

  points = points;
  myLatLng = { lat: 50.01146223876953, lng: 19.82978582382202 };
  mapOptions: google.maps.MapOptions = {
    center: this.myLatLng,
    zoom: 20,
  };

  iconSize = 6;
  icon = {
    url: "/assets/images/dot10px.svg",
    scaledSize: new google.maps.Size(this.iconSize, this.iconSize),
    anchor: new google.maps.Point(this.iconSize/2, this.iconSize/2)
  }

  markerOptions: google.maps.MarkerOptions = {icon: this.icon};

  dogTrailOptions = {
    path: this.dogTrail,
    strokeColor: '#ff0000',
    strokeOpacity: 1.0,
    strokeWeight: 2,
    };

  personTrailOptions = {
    path: this.personTrail,
    strokeColor: '#0000ff',
    strokeOpacity: 1.0,
    strokeWeight: 4,
  };


  displayInfoWindow(marker: MapMarker, infoWindow: MapInfoWindow) {
    console.log("marker click");
    infoWindow.open(marker);
  }

  markStart() {}
  markEnd() {}
}
