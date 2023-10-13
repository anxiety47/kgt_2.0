import { Component } from '@angular/core';
import { TranslateService } from '@ngx-translate/core';
import { faDog, faMap } from '@fortawesome/free-solid-svg-icons';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss']
})
export class AppComponent {
  title = 'kgt';
  dogIcon = faDog;
  mapIcon = faMap;

  constructor(private translate: TranslateService) {
    translate.setDefaultLang('pl');
    translate.use('pl');
  }
}
