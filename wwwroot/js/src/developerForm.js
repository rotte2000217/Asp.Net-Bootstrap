﻿import { createRoot } from 'react-dom/client';
import React from 'react';
import FormManager from '../components/formManager.js';

class DeveloperForm extends React.Component {
    constructor(props) {
        super(props);
    }

    render() {
        return (
            <div className="small main-content container">
                <FormManager
                    url="/Developer"
                    title={localization.Developer}
                    rows={[
                        {
                            label: localization.Name,
                            property: 'name',
                            required: true
                        }
                    ]}
                />
            </div>
        );
    }
}

createRoot(document.getElementById('root')).render(<DeveloperForm />);