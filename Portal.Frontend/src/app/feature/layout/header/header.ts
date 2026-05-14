import { isPlatformBrowser } from '@angular/common';
import { Component, Inject, PLATFORM_ID, Renderer2 } from '@angular/core';

@Component({
  selector: 'app-header',
  standalone: false,
  templateUrl: './header.html',
})
export class HeaderComponent {


  showThemeToggle = true;
  showUserMenu = false;
  showNotificationMenu = false;
  showSettingMenu = false;
  showAppsMenu = false;
  showLanguageMenu = false;

  isLoggedIn = false;

  theme : any= "light";
  constructor(
    private renderer: Renderer2,
    @Inject(PLATFORM_ID) private platformId: Object
  ) {}

  ngOnInit() {
    if (isPlatformBrowser(this.platformId)) {
      this.theme = localStorage.getItem("theme")? localStorage.getItem("theme") : this.theme;
      this.renderer.setAttribute(document.documentElement, 'data-bs-theme', this.theme);
    }
  }

  changeTheme(theme : any){
      this.theme = theme;
      localStorage.setItem("theme", theme); 
      this.renderer.setAttribute(document.documentElement, 'data-bs-theme', this.theme);
  }
}