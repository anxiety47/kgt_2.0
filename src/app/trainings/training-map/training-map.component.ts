import { Component, Input, OnInit } from '@angular/core';
import { TrackPoint } from '../models/trainings';
import { MapInfoWindow, MapMarker } from '@angular/google-maps';

@Component({
  selector: 'app-training-map',
  templateUrl: './training-map.component.html',
  styleUrls: ['./training-map.component.scss']
})
export class TrainingMapComponent implements OnInit {

  @Input() dogTrail: TrackPoint[] = [];
  @Input() personTrail: TrackPoint[] = [];

  dogTrailOptions: any;
  personTrailOptions: any;

  ngOnInit() {
    this.dogTrailOptions = {
      path: this.dogTrail,
      strokeColor: '#ff0000',
      strokeOpacity: 1.0,
      strokeWeight: 2,
      };
  
    this.personTrailOptions = {
      path: this.personTrail,
      strokeColor: '#0000ff',
      strokeOpacity: 1.0,
      strokeWeight: 4,
    };
  
  }

  myLatLng = { lat: 50.109205171465874, lng: 19.779058629646897 };
  mapOptions: google.maps.MapOptions = {
    center: this.myLatLng,
    zoom: 30,
  };

  iconSize = 6;
  icon = {
    url: "/assets/images/dot10px.svg",
    scaledSize: new google.maps.Size(this.iconSize, this.iconSize),
    anchor: new google.maps.Point(this.iconSize/2, this.iconSize/2)
  }

  markerOptions: google.maps.MarkerOptions = {icon: this.icon};


  displayInfoWindow(marker: MapMarker, infoWindow: MapInfoWindow) {
    console.log("open window");
    infoWindow.open(marker);
  }


  // only for dog trail; TODO: handle person trail
  markStart(index: number) {
    this.dogTrail.splice(0, index);
    this.dogTrailOptions = {...this.dogTrailOptions};
  }

  markEnd(index: number) {
    this.dogTrail.splice(index+1);
    this.dogTrailOptions = {...this.dogTrailOptions};
  }
  //

}
