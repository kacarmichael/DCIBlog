import '../../wwwroot/app.css';
import CorpsListing from './CorpsListing';

function SideBar() {
    return (
        
            <div class="relative inset-y-0 left-0">
                <CorpsListing/>
                <CorpsListing/>
                <CorpsListing/>
            </div>
        
  );
}

export default SideBar;